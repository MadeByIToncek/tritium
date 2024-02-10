using SQLite;
using System.Data;

namespace Tritium
{
    public class SQLite
    {

        private readonly SQLiteConnection _db;
        public SQLite(string path)
        {
            _db = new SQLiteConnection(path);
            _db.CreateTable<Klient>();
            _db.CreateTable<Navsteva>();
        }
    }
}
