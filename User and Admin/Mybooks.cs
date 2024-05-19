using LiveLibraryDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library_Managment_System
{
    public partial class Mybooks : Form
    {
        SqlConnection Con = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        DBConnect Dbconect = new DBConnect();
        SqlDataReader dr;
        public Mybooks(int LogginID)
        {
            if (LogginID == -1)
            {
                MessageBox.Show("Please Login First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InitializeComponent();
                Con = new SqlConnection(Dbconect.myConnection());
                LoadUserBooks(LogginID);
            }
        }

        public void LoadUserBooks(int logginID) // load user 
        {
            int i = 0;
            DgridvMybooks.Rows.Clear();
            Con.Open();

            // Create the SqlCommand object with the SQL query and connection
            Cmd = new SqlCommand("SELECT [title], [categoryId], [isbn], [returnDate] FROM Books bk JOIN borrow bw ON bk.bookId = bw.bookId WHERE bw.userId = @LogginID", Con);

            // Add parameters to the SqlCommand object
            Cmd.Parameters.AddWithValue("@LogginID", logginID);

            // Execute the query
            dr = Cmd.ExecuteReader();

            while (dr.Read())
            {
                i++;
                DgridvMybooks.Rows.Add(i, dr["title"].ToString(), dr["categoryId"].ToString(), dr["isbn"].ToString(), dr["returnDate"].ToString());
            }

            dr.Close();
            Con.Close();
        }

    }
}
