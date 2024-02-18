using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Metadata;
using NHibernate.Tool.hbm2ddl;
using System.Collections;
using System.Reflection;
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
            _sessionFactory = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile(path))
                .Mappings(m =>
                     m.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(TreatConfiguration)
                .BuildSessionFactory();
            isLocal = true;
            //MigrateIfNeeded(_sessionFactory.OpenSession());
        }
        public DatabaseController(string server, int port, string database, string user, string password)
        {
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
            //MigrateIfNeeded(_sessionFactory.OpenSession());
        }

        private void MigrateIfNeeded(ISession session)
        {
            ITransaction transaction = session.BeginTransaction();
            transaction.Begin();
            if(session.Get<PatogenProgram>(1)==null)
            {
                var assembly = Assembly.GetExecutingAssembly();
                string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("migration.csv"));

                const int BufferSize = 128;
                using (var fileStream = assembly.GetManifestResourceStream(resourceName))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                {
                    var lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
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

                        PatogenProgram pp = new() { 
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

                        session.Save(pp);
                    }
                }
            };
        }

        private static void TreatConfiguration(Configuration configuration)
        {
            var update = new SchemaUpdate(configuration);
            update.Execute(false, true);
        }

        internal IList<Klient> ListClients()
        {
            using (var session = _sessionFactory.OpenSession())
            {
                // retreive all stores and display them
                using (session.BeginTransaction())
                {
                    return session.CreateCriteria(typeof(Klient))
                      .List<Klient>();
                }
            }
        }

        internal IList<PatogenProgram> ListPatogenPrograms()
        {
            using var session = _sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                return session.CreateCriteria(typeof(PatogenProgram))
                  .List<PatogenProgram>();
            }
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
    }
}
