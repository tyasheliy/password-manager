using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyLoger.Data.Providers
{
    public static class SQLiteProvider
    {
        private static SQLiteManager _db = null;
        private static string _path = "./db.db";

        public static SQLiteManager? Get()
        {
            var instance = _db;

            if (instance == null)
            {
                _db = new SQLiteManager(_path);
            }

            return instance;
        }
    }
}
