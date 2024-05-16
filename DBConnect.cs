using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveLibraryDB
{
    internal class DBConnect
    {
        private string connectionString;
        public string myConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Body\Library-Managment-System\libraryDB\LiveLibraryDB.mdf;Integrated Security=True;Connect Timeout=30";
            return connectionString;
        }
    }
}
