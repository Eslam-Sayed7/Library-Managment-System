using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Managment_System
{
   
    public partial class AdminHome : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;

        public AdminHome()
        {
            InitializeComponent();
        }
        public void LoadLibraryBooks() // load available library books for a user to borrow 
        {
            string conncetion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Body\Library-Managment-System\libraryDB\LiveLibraryDB.mdf;Integrated Security=True;Connect Timeout=30;";
            con =new SqlConnection(conncetion);
            int i = 0;
            DgridvLibrarybooks.Rows.Clear();
            con.Open();
            // Create the SqlCommand object with the SQL query and connection
            cmd = new SqlCommand(
                "SELECT bk.bookId, bk.title, cat.name AS categoryName, bk.isbn, bk.publicationYear, au.name AS authorName " +
                "FROM books AS bk " +
                "JOIN category AS cat ON cat.categoryId = bk.categoryId " +
                "JOIN authors AS au ON au.authorId = bk.authorId " +
                "LEFT OUTER JOIN borrow AS bw ON bk.bookId = bw.bookId WHERE bw.bookId IS NULL"
            , con);

            // Add parameters to the SqlCommand object
            cmd.Parameters.AddWithValue("@LogginID", GlobalVariables.GlobalVariables.uid);

            dr = cmd.ExecuteReader(); // Execute the query

            while (dr.Read())
            {
                i++;
                DgridvLibrarybooks.Rows.Add(i, dr["bookId"].ToString(), dr["title"].ToString(), dr["categoryName"].ToString(), dr["isbn"].ToString(), dr["publicationYear"].ToString(), dr["authorName"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btn_My_books_Click(object sender, EventArgs e)
        {
            DeleteBook x = new DeleteBook();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            AddBook x = new AddBook();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login x = new Login();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Setting mysettings = new Setting();
            mysettings.Show();
        }
    }
}
