using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using MySqlX.XDevAPI;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Metadata;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Transform;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Tritium.Entities;

namespace Tritium
{
    public class DatabaseController
    {
        private readonly ISessionFactory _sessionFactory;
        readonly internal bool isLocal;

        public DatabaseController(string path)
        {
            if (Program.SplashScreen != null)
            {
                Program.SplashScreen.SetCurrentProgressMessage("DB", "Connecting");
            }

            _sessionFactory = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile(path))
                .Mappings(m =>
                     m.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(TreatConfiguration)
                .BuildSessionFactory();
            isLocal = true; 

            if (Program.SplashScreen != null)
            {
                Program.SplashScreen.SetCurrentProgressMessage("DB", "Connected");
            }

            MigrateIfNeeded(_sessionFactory.OpenSession());
        }
        public DatabaseController(string server, int port, string database, string user, string password)
        {
            if (Program.SplashScreen != null)
            {
                Program.SplashScreen.SetCurrentProgressMessage("DB", "Connecting");
            }
            
            _sessionFactory = Fluently.Configure()
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

            if (Program.SplashScreen != null)
            {
                Program.SplashScreen.SetCurrentProgressMessage("DB", "Connected");
            }

            MigrateIfNeeded(_sessionFactory.OpenSession());
        }

        private static void MigrateIfNeeded(ISession session)
        {
            if (Program.SplashScreen != null)
            {
                Program.SplashScreen.SetCurrentProgressMessage("DB Migrations", "Checking Patogens");
            }

            ITransaction transaction = session.BeginTransaction();
            transaction.Begin();
            if (session.CreateSQLQuery("SELECT * FROM PatogenProgram").List().Count < 1)
            {
                if (Program.SplashScreen != null)
                {
                    Program.SplashScreen.SetCurrentProgressMessage("DB Migrations", "Patogen migration started");
                }
                var assembly = Assembly.GetExecutingAssembly();
                string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("patogenprogramy.csv"));

                const int BufferSize = 128;
                using var fileStream = assembly.GetManifestResourceStream(resourceName);
                using var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize);
                var lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
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

                    if (Program.SplashScreen != null)
                    {
                        Program.SplashScreen.SetCurrentProgressMessage("DB Migrations", "Migrating patogens, " + cline + "/" + lines.Length + " done");
                    }

                    session.Save(pp);
                    cline++;
                }

                if (Program.SplashScreen != null)
                {
                    Program.SplashScreen.SetCurrentProgressMessage("DB Migrations", "Patogen migration finished");
                }
            } else
            {
                if (Program.SplashScreen != null)
                {
                    Program.SplashScreen.SetCurrentProgressMessage("DB Migrations", "Patogen migration not needed");
                }
            };


            if (Program.SplashScreen != null)
            {
                Program.SplashScreen.SetCurrentProgressMessage("DB Migrations", "Checking Okruhy");
            }
            if (session.CreateSQLQuery("SELECT * FROM Okruh").List().Count < 1)
            {
                if (Program.SplashScreen != null)
                {
                    Program.SplashScreen.SetCurrentProgressMessage("DB Migrations", "Okruhy migration started");
                }
                var assembly = Assembly.GetExecutingAssembly();
                string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("okruhy.csv"));

                const int BufferSize = 128;
                using var fileStream = assembly.GetManifestResourceStream(resourceName);
                using var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize);
                var lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
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

                    if (Program.SplashScreen != null)
                    {
                        Program.SplashScreen.SetCurrentProgressMessage("DB Migrations", "Migrating okruhy, " + cline + "/" + lines.Length + " done");
                    }
                    session.Save(okruh);
                    cline++;
                }

                if (Program.SplashScreen != null)
                {
                    Program.SplashScreen.SetCurrentProgressMessage("DB Migrations", "Okruhy migration finished");
                }
            }
            else
            {
                if (Program.SplashScreen != null)
                {
                    Program.SplashScreen.SetCurrentProgressMessage("DB Migrations", "Okruhy migration not needed");
                }
            }

            transaction.Commit();
        }

        private static void TreatConfiguration(Configuration configuration)
        {
            if (Program.SplashScreen != null)
            {
                Program.SplashScreen.SetCurrentProgressMessage("DB Migrations", "Migrating table layout");
            }
            var update = new SchemaUpdate(configuration);
            update.Execute(false, true);
            if (Program.SplashScreen != null)
            {
                Program.SplashScreen.SetCurrentProgressMessage("DB Migrations", "Table migration finished");
            }
        }

        internal IList<Klient> ListClients()
        {
            using var session = _sessionFactory.OpenSession();
            // retreive all stores and display them
            using (session.BeginTransaction())
            {
                return session.CreateCriteria(typeof(Klient))
                  .List<Klient>();
            }
        }

        internal IList<PatogenProgram> ListPatogenPrograms()
        {
            using var session = _sessionFactory.OpenSession();
            return session.CreateCriteria(typeof(PatogenProgram))
              .List<PatogenProgram>();
        }

        internal void UpdatePatogenProgram(PatogenProgram pp)
        {
            using var session = _sessionFactory.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            session.Update(pp);
            trans.Commit();
        }

        internal void InsertPatogenProgram(PatogenProgram pp)
        {
            using var session = _sessionFactory.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            session.Save(pp);
            trans.Commit();
        }

        internal void DeletePatogenProgram(PatogenProgram pp)
        {
            using var session = _sessionFactory.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            session.Delete(pp);
            trans.Commit();
        }

        internal IList<Okruh> ListOkruhy()
        {
            using var session = _sessionFactory.OpenSession();
            return session.CreateCriteria(typeof(Okruh))
              .List<Okruh>();
        }

        internal IList<Navsteva> GetMeetingsForClient(int clientId)
        {
            using var session = _sessionFactory.OpenSession();
            var query = session.QueryOver<Navsteva>()
                .Where(i => i.Client.Id == clientId)
                .TransformUsing(new DistinctRootEntityResultTransformer());
            return query.List<Navsteva>();
        }

        internal void CreateEmptyMeetingWithClient(Klient client)
        {
            ISession session = _sessionFactory.OpenSession();
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

            session.SaveOrUpdate(client);

            transaction.Commit();
        }

        private Okruh GetEmptyOkruh()
        {
            throw new NotImplementedException();
        }

        internal async Task CreateEmptyClient()
        {
            ISession session = _sessionFactory.OpenSession();
            ITransaction transaction = session.BeginTransaction();
            transaction.Begin();
            Klient klient = new()
            {
                DatumNarozeni = DateTime.UnixEpoch
            };

            await session.SaveAsync(klient);

            await transaction.CommitAsync();
        }

        internal Klient GetClientById(int id)
        {
            using var session = _sessionFactory.OpenSession();
            var query = session.QueryOver<Klient>()
                .Where(i => i.Id == id)
                .TransformUsing(new DistinctRootEntityResultTransformer());
            return query.SingleOrDefault<Klient>();
        }

        internal Navsteva GetMeetingsById(int id)
        {
            using var session = _sessionFactory.OpenSession();
            var query = session.QueryOver<Navsteva>()
                .Where(i => i.Id == id)
                .TransformUsing(new DistinctRootEntityResultTransformer());
            return query.SingleOrDefault<Navsteva>();
        }

        internal async Task UpdateClient(Klient client)
        {
            using var session = _sessionFactory.OpenSession();
            using var trans = session.BeginTransaction();
            trans.Begin();
            await session.UpdateAsync(client);
            await trans.CommitAsync();
        }

        internal IList<Sken> GetScansForMeeting(int id)
        {
            using var session = _sessionFactory.OpenSession();
            var query = session.QueryOver<Sken>()
                .Where(i => i.Navsteva.Id == id)
                .TransformUsing(new DistinctRootEntityResultTransformer());
            return query.List<Sken>();
        }
    }
}
