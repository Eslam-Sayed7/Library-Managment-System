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
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= D:\CS\2 - Second year\[2] Second term\DataBases\Project\Library Managment System\libraryDB\LiveLibraryDB.mdf;Integrated Security=False;Connect Timeout=30";
            return connectionString;
        }
    }
}
