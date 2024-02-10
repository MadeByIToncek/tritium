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

        public DatabaseController(string path)
        {
            _sessionFactory = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile(path))
                .Mappings(m =>
                     m.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(TreatConfiguration)
                .BuildSessionFactory();
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

        internal void LoadDemoSample()
        {
            using (var session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var klient1 = new Klient
                    {
                        Jmeno = "Jméno Příjmení",
                        DatumNarozeni = DateTime.MinValue,
                        Telefon = "+420 123 456 789",
                        Email = "email@domena.tld",
                        Adresa = "Ulice 123, Město 123 45",
                        UvodniSchuzka = DateTime.Now
                    };
                    var navsteva1 = new Navsteva
                    {
                        Client = klient1,
                        Date = DateTime.Now
                    };
                    klient1.PridatNavstevu(navsteva1);

                    session.SaveOrUpdate(klient1);

                    transaction.Commit();
                }
            }
        }
    }
}
