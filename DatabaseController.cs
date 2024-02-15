using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Metadata;
using NHibernate.Tool.hbm2ddl;
using System.Collections;
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
            using (var session = _sessionFactory.OpenSession())
            {
                // retreive all stores and display them
                using (session.BeginTransaction())
                {
                    return session.CreateCriteria(typeof(PatogenProgram))
                      .List<PatogenProgram>();
                }
            }
        }

        internal void UpdatePatogenProgram(PatogenProgram pp)
        {
            using var session = _sessionFactory.OpenSession();
            using (session.BeginTransaction())
            {
                session.Update(pp);
                session.Close();
            }
        }
    }
}
