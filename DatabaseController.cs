using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Data;
using FluentNHibernate.Utils;
using MySqlX.XDevAPI;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Metadata;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Transform;
using System.Collections;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;
using Tritium.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tritium
{
    public class DatabaseController
    {
        private readonly ISessionFactory sf;
        readonly internal bool isLocal;

        public DatabaseController(string path)
        {
            Program.SplashScreen?.SetCurrentProgressMessage("DB", "Connecting");

            sf = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile(path))
                .Mappings(m =>
                     m.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(TreatConfiguration)
                .BuildSessionFactory();
            isLocal = true; 

            Program.SplashScreen?.SetCurrentProgressMessage("DB", "Connected");

            MigrateIfNeededAsync(sf.OpenSession());
        }
        public DatabaseController(string server, int port, string database, string user, string password)
        {
            Program.SplashScreen?.SetCurrentProgressMessage("DB", "Connecting");
            
            sf = Fluently.Configure()
                .Database(MySQLConfiguration.Standard.ConnectionString(c =>
                    c.Server(server)
                     .Port(port)
                     .Database(database)
                     .Username(user)
                     .Password(password)))
                .Mappings(m =>
                     m.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(TreatConfiguration)
                .BuildSessionFactory();

            isLocal = false;

            Program.SplashScreen?.SetCurrentProgressMessage("DB", "Connected");

            MigrateIfNeededAsync(sf.OpenSession());
        }

        private static void MigrateIfNeededAsync(ISession session)
        {
            Program.SplashScreen?.SetCurrentProgressMessage("DB Migrations", "Checking Patogens");

            ITransaction transaction = session.BeginTransaction();
            transaction.Begin();
            if ((session.CreateSQLQuery("SELECT * FROM PatogenProgram").List()).Count < 1)
            {
                Program.SplashScreen?.SetCurrentProgressMessage("DB Migrations", "Patogen migration started");
                var assembly = Assembly.GetExecutingAssembly();
                string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("patogenprogramy.csv"));

                const int BufferSize = 128;
                using var fileStream = assembly.GetManifestResourceStream(resourceName);
                using var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize);
                var lines = (streamReader.ReadToEnd()).Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                int cline = 0;
                foreach (var line in lines)
                {
                    string[] parts = line.Split(",");
                    for (int i = 0; i < parts.Length; i++)
                    {
                        parts[i] = parts[i].Trim().Replace("\"", "");
                    }
                    string name = parts[0];
                    string type = parts[1];
                    int time = int.Parse(parts[2]);
                    bool alone = parts[3] == "1";
                    bool onkovir = parts[4] == "1";
                    bool parovy = parts[5] == "1";
                    string morty = parts[6];
                    string SKPs = parts[7];
                    string okruhy = parts[8];
                    string poznamky = parts[9];

                    PatogenProgram pp = new()
                    {
                        Name = name,
                        Type = type,
                        Time = time,
                        Samostatne = alone,
                        Onkovir = onkovir,
                        Par = parovy,
                        Okruhy = okruhy,
                        Poznamky = poznamky,
                        MORTFRQs = morty,
                        StabKompAPasm = SKPs,

                    };

                    Program.SplashScreen?.SetCurrentProgressMessage("DB Migrations", "Migrating patogens, " + cline + "/" + lines.Length + " done");

                    session.Save(pp);
                    cline++;
                }

                Program.SplashScreen?.SetCurrentProgressMessage("DB Migrations", "Patogen migration finished");
            } else
            {
                Program.SplashScreen?.SetCurrentProgressMessage("DB Migrations", "Patogen migration not needed");
            };


            Program.SplashScreen?.SetCurrentProgressMessage("DB Migrations", "Checking Okruhy");
            if (session.CreateSQLQuery("SELECT * FROM Okruh").List().Count < 1)
            {
                Program.SplashScreen?.SetCurrentProgressMessage("DB Migrations", "Okruhy migration started");
                var assembly = Assembly.GetExecutingAssembly();
                string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("okruhy.csv"));

                const int BufferSize = 128;
                using var fileStream = assembly.GetManifestResourceStream(resourceName);
                using var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize);
                var lines = (streamReader.ReadToEnd()).Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                int cline = 0;
                foreach (var line in lines)
                {
                    string[] parts = line.Split(",");
                    for (int i = 0; i < parts.Length; i++)
                    {
                        parts[i] = parts[i].Trim().Replace("\"", "");
                    }
                    string zkratka = parts[0];
                    string nazev = parts[1];
                    int cas = int.Parse(parts[2]);

                    Okruh okruh = new()
                    {
                        Name = nazev,
                        Zkratka = zkratka,
                        Delka = cas
                    };

                    Program.SplashScreen?.SetCurrentProgressMessage("DB Migrations", "Migrating okruhy, " + cline + "/" + lines.Length + " done");
                    session.Save(okruh);
                    cline++;
                }

                Program.SplashScreen?.SetCurrentProgressMessage("DB Migrations", "Okruhy migration finished");
            }
            else
            {
                Program.SplashScreen?.SetCurrentProgressMessage("DB Migrations", "Okruhy migration not needed");
            }

            transaction.Commit();
        }

        private static void TreatConfiguration(Configuration configuration)
        {
            Program.SplashScreen?.SetCurrentProgressMessage("DB Migrations", "Migrating table layout");
            var update = new SchemaUpdate(configuration);
            update.Execute(false, true);
            Program.SplashScreen?.SetCurrentProgressMessage("DB Migrations", "Table migration finished");
        }

        internal IList<Klient> ListClients()
        {
            using var session = sf.OpenSession();
            // retreive all stores and display them
            using (session.BeginTransaction())
            {
                return session.CreateCriteria(typeof(Klient))
                  .List<Klient>();
            }
        }

        internal IList<PatogenProgram> ListPatogenPrograms()
        {
            using var session = sf.OpenSession();
            return session.CreateCriteria(typeof(PatogenProgram))
              .List<PatogenProgram>();
        }

        internal async Task UpdatePatogenProgram(PatogenProgram pp)
        {
            using var session = sf.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            await session.EvictAsync(pp);
            await session.UpdateAsync(pp);
            await trans.CommitAsync();
            session.Close();
        }

        internal async Task InsertPatogenProgram(PatogenProgram pp)
        {
            using var session = sf.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            await session.SaveAsync(pp);
            await trans.CommitAsync();
            session.Close();
        }

        internal async Task DeletePatogenProgram(PatogenProgram pp)
        {
            using var session = sf.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            await session.DeleteAsync(pp);
            await trans.CommitAsync();
            session.Close();
        }

        internal IList<Okruh> ListOkruhy()
        {
            using var session = sf.OpenSession();
            return session.CreateCriteria(typeof(Okruh))
              .List<Okruh>();
        }

        internal IList<Navsteva> GetMeetingsForClient(int clientId)
        {
            using var session = sf.OpenSession();
            var query = session.QueryOver<Navsteva>()
                .Where(i => i.Client.Id == clientId)
                .TransformUsing(new DistinctRootEntityResultTransformer());
            return query.List<Navsteva>();
        }

        internal async Task CreateEmptyMeetingWithClient(Klient client)
        {
            ISession session = sf.OpenSession();
            ITransaction transaction = session.BeginTransaction();
            transaction.Begin();
            Navsteva navsteva = new()
            {
                Client = client,
                Date = DateTime.Now,
                AktualniPotize = "",
                CoChceVyresit = "",
                CoNejviceObtezuje = "",
                SkenOkr1 = Program.db.GetEmptyOkruh(),
                SkenOkr2 = Program.db.GetEmptyOkruh()
            };
            client.PridatNavstevu(navsteva);
            await session.EvictAsync(client);
            await session.SaveOrUpdateAsync(client);
            await transaction.CommitAsync();
            session.Close();
        }

        private Okruh GetEmptyOkruh()
        {
            using var session = sf.OpenSession();
            var query = session.QueryOver<Okruh>()
                .Where(i => i.Zkratka == "NULL")
                .TransformUsing(new DistinctRootEntityResultTransformer());
            return query.SingleOrDefault<Okruh>();
        }

        internal async Task CreateEmptyClient()
        {
            ISession session = sf.OpenSession();
            ITransaction transaction = session.BeginTransaction();

            Klient klient = new()
            {
                Jmeno = "",
                DatumNarozeni = DateTime.UnixEpoch
            };

            transaction.Begin();
            await session.SaveAsync(klient);
            await transaction.CommitAsync();
            session.Close();
        }

        internal Klient GetClientById(int id)
        {
            using var session = sf.OpenSession();
            var query = session.QueryOver<Klient>()
                .Where(i => i.Id == id)
                .TransformUsing(new DistinctRootEntityResultTransformer());
            return query.SingleOrDefault<Klient>();
        }

        internal Navsteva GetMeetingById(int id)
        {
            using var session = sf.OpenSession();
            var query = session.QueryOver<Navsteva>()
                .Where(i => i.Id == id)
                .TransformUsing(new DistinctRootEntityResultTransformer());
            return query.SingleOrDefault<Navsteva>();
        }

        internal async Task UpdateClient(Klient client)
        {
            using var session = sf.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            await session.EvictAsync(client);
            await session.UpdateAsync(client);
            await trans.CommitAsync();
            session.Close();
        }

        internal IList<Sken> GetScansForMeeting(int id)
        {
            using var session = sf.OpenSession();
            var query = session.QueryOver<Sken>()
                .Where(i => i.Navsteva.Id == id)
                .TransformUsing(new DistinctRootEntityResultTransformer());
            return query.List<Sken>();
        }

        internal Sken GetScanById(int id)
        {
            using var session = sf.OpenSession();
            var query = session.QueryOver<Sken>()
                .Where(i => i.Id == id)
                .TransformUsing(new DistinctRootEntityResultTransformer());
            return query.SingleOrDefault<Sken>();
        }

        internal async Task<int> InsertSken(Navsteva navsteva)
        {
            using var session = sf.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            int i = (int)await session.SaveAsync(new Sken()
            {
                Okruh = GetEmptyOkruh(),
                FRQ = 0,
                HRV = 0,
                Navsteva = navsteva,
                Patogen = GetEmptyPatogen()
            }) ;
            await trans.CommitAsync();
            return i;
        }

        internal PatogenProgram GetEmptyPatogen()
        {
            using var session = sf.OpenSession();
            var query = session.QueryOver<PatogenProgram>()
                .Where(i => i.Type == "NULL")
                .TransformUsing(new DistinctRootEntityResultTransformer());
            return query.SingleOrDefault<PatogenProgram>();
        }

        internal async Task UpdateSken(Sken s)
        {
            using var session = sf.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            await session.EvictAsync(s);
            await session.UpdateAsync(s);
            await trans.CommitAsync();
            session.Close();
        }

        internal void UpdateMeeting(Navsteva meeting)
        {
            using var session = sf.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            session.Evict(meeting);
            session.Update(meeting);
            trans.Commit();
            session.Close();
        }

        internal Okruh GetOkruhByName(string name)
        {
            using var session = sf.OpenSession();
            var query = session.QueryOver<Okruh>()
                .Where(i => i.Name == name)
                .TransformUsing(new DistinctRootEntityResultTransformer());
            return query.SingleOrDefault<Okruh>();
        }

        internal async Task DeleteSken(int id)
        {
            using var session = sf.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            await session.DeleteAsync(GetScanById(id));
            await trans.CommitAsync();
            session.Close();
        }


        internal async Task DeleteClient(int id)
        {
            using var session = sf.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            await session.DeleteAsync(GetClientById(id));
            await trans.CommitAsync();
            session.Close();
        }

        internal PatogenProgram GetPatogenById(string v)
        {
            using var session = sf.OpenSession();
            var query = session.QueryOver<PatogenProgram>()
                .Where(i => i.Id == int.Parse(v))
                .TransformUsing(new DistinctRootEntityResultTransformer());
            return query.SingleOrDefault<PatogenProgram>() ?? GetEmptyPatogen();
        }

        internal IEnumerable<Plan> GetPlansForMeeting(int id)
        {
            using var session = sf.OpenSession();
            var query = session.QueryOver<Plan>()
                .Where(i => i.Navsteva.Id == id)
                .TransformUsing(new DistinctRootEntityResultTransformer());
            return query.List<Plan>();
        }

        internal async void DeletePlan(Plan plan)
        {
            using var session = sf.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            await session.EvictAsync(plan);
            await session.DeleteAsync(plan);
            await trans.CommitAsync();
            session.Close();
        }

        internal async void UpdatePlan(Plan plan)
        {
            using var session = sf.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            await session.EvictAsync(plan);
            await session.UpdateAsync(plan);
            await trans.CommitAsync();
            session.Close();
        }

        internal void Shutdown()
        {
            sf.EvictQueries();
            foreach (var collectionMetadata in sf.GetAllCollectionMetadata())
                sf.EvictCollection(collectionMetadata.Key);
            foreach (var classMetadata in sf.GetAllClassMetadata())
                sf.EvictEntity(classMetadata.Key);

            sf.Close();
            sf.Dispose();
        }

        internal int GetNextOrderForPlan(Navsteva meeting)
        {
            using var session = sf.OpenSession();
            int query = session.QueryOver<Plan>()
                .Select(Projections.Max<Plan>(x => x.Poradi)).SingleOrDefault<int>();
                return query + 1;
        }

        internal async void ClearPlanEntry(PlanEntry entry)
        {
            using var session = sf.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            await session.EvictAsync(entry);
            entry.Program = GetEmptyPatogen();
            await session.UpdateAsync(entry);
            await trans.CommitAsync();
            session.Close();
        }

        internal PlanEntry GetPlanEntry(int planEntryID)
        {
            using var session = sf.OpenSession();
            var query = session.QueryOver<PlanEntry>()
                .Where(i => i.Id == planEntryID)
                .TransformUsing(new DistinctRootEntityResultTransformer());
            return query.SingleOrDefault<PlanEntry>();
        }

        internal async void UpdatePlanEntry(PlanEntry entry)
        {
            using var session = sf.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            await session.EvictAsync(entry);
            await session.UpdateAsync(entry);
            await trans.CommitAsync();
            session.Close();
        }

        internal int CreateNewEmptyPlanEntry(Plan plan, int order)
        {
            ISession session = sf.OpenSession();
            ITransaction transaction = session.BeginTransaction();
            transaction.Begin();
            PlanEntry entry = new()
            {
                Plan = plan,
                Program = GetEmptyPatogen(),
                Poradi = order
            };
            plan.PridatDavku(entry);
            session.Evict(entry);
            int v = (int)session.Save(entry);
            transaction.Commit();
            session.Close();
            return v;
        }
    }
}
