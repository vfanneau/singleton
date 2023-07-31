using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public abstract class Db
    {
        private DatabaseSingleton _database;

        public Db()
        {
            _database = DatabaseSingleton.instance;
        }

        public void PrintDbInfo()
        {
            _database.PrintInfo();
        }
    }
}
