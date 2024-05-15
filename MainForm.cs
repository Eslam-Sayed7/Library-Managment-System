using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LiveLibraryDB;
using System.Globalization;


namespace Library_Managment_System
{
    public partial class MainForm : Form
    {
        SqlConnection Con = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        DBConnect Dbconect = new DBConnect();
        SqlDataReader dr;


        public MainForm(int uid)
        {
            /*label_user_name.Text = "user name : " + uid.ToString();*/
            InitializeComponent();
            Con = new SqlConnection(Dbconect.myConnection());
            LoadLibraryBooks();
            /*Con.Open();*/
            // MessageBox.Show("Database is connected");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_My_books_Click(object sender, EventArgs e)
        {
            Mybooks mybooks = new Mybooks(GlobalVariables.GlobalVariables.uid);
            mybooks.Show();
        }

        private void logout_Click(object sender, EventArgs e) //
        {
            Login x = new Login();
            this.Hide();
            x.ShowDialog();
            this.Close();

        }
        public void LoadLibraryBooks() // load available library books for a user to borrow 
        {
            int i = 0;
            DgridvLibrarybooks.Rows.Clear();
            Con.Open();

            // Create the SqlCommand object with the SQL query and connection
            Cmd = new SqlCommand(
            "SELECT bk.bookId, bk.title, cat.name AS categoryName, bk.isbn, bk.publicationYear " +
            "FROM Books AS bk " +
            "JOIN category AS cat ON cat.categoryId = bk.categoryId " +
            "LEFT JOIN borrow AS bw ON bk.bookId = bw.bookId"
            , Con);



            // Add parameters to the SqlCommand object
            Cmd.Parameters.AddWithValue("@LogginID", GlobalVariables.GlobalVariables.uid);

            // Execute the query
            dr = Cmd.ExecuteReader();

            while (dr.Read())
            {
                i++;
                DgridvLibrarybooks.Rows.Add(i, dr["bookId"].ToString(), dr["title"].ToString(), dr["categoryName"].ToString(), dr["isbn"].ToString(), dr["publicationYear"].ToString());
            }
            dr.Close();
            Con.Close();
        }

        private void btn_settings_Click_1(object sender, EventArgs e)
        {
            Setting mysettings = new Setting();
            mysettings.Show();
        }
    }
}
