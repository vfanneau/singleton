using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public sealed class DatabaseSingleton
    {
        private string _dbName;
        private string _connectionString;

        private static readonly DatabaseSingleton _instance = new DatabaseSingleton();

        public static DatabaseSingleton instance
        {
            get
            {
                return _instance;
            }
        }

        static DatabaseSingleton()
        {
        }

        private DatabaseSingleton()
        {
            _dbName = "myDb";
            _connectionString = "myConnectionString";
        }

        public void PrintInfo()
        {
            Console.WriteLine(_dbName);
            Console.WriteLine(_connectionString);
        }
    }
}
