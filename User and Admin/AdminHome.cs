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
using LiveLibraryDB;
using Library_Managment_System;
using Library_Managment_System.User_and_Admin;

namespace Library_Managment_System
{
   
    public partial class AdminHome : Form
    {
        SqlConnection AdminHomeConnection;
        DBConnect Dbconnect = new DBConnect();
        public AdminHome()
        {
            InitializeComponent();
            SqlConnection AdminHomeConnection = new SqlConnection(Dbconnect.myConnection());
            LoadLibraryBooks();
        }
        public void LoadLibraryBooks() // load available library books for a user to borrow 
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CS\2 - Second year\[2] Second term\DataBases\Project\Library Managment System\libraryDB\LiveLibraryDB.mdf;Integrated Security=False;Connect Timeout=30";
             AdminHomeConnection = new SqlConnection(connectionString);
            int i = 0;
            AdminDgridvLibrarybooks.Rows.Clear();
            AdminHomeConnection.Open();

            // Create the SqlCommand object with the SQL query and connection
            SqlCommand Cmd = new SqlCommand(
                "SELECT bk.bookId, bk.title, cat.name AS categoryName, bk.isbn, bk.publicationYear, au.name AS authorName " +
                "FROM books AS bk " +
                "JOIN category AS cat ON cat.categoryId = bk.categoryId " +
                "JOIN authors AS au ON au.authorId = bk.authorId " 
            , AdminHomeConnection);

            SqlDataReader dr = Cmd.ExecuteReader(); // Execute the query

            while (dr.Read())
            {
                i++;
                AdminDgridvLibrarybooks.Rows.Add(i, dr["bookId"].ToString(), dr["title"].ToString(), dr["categoryName"].ToString(), dr["isbn"].ToString(), dr["publicationYear"].ToString(), dr["authorName"].ToString());
            }
            dr.Close();
            AdminHomeConnection.Close();
        }
        private void DelteBook_Click(object sender, EventArgs e)
        {
            DeleteBook x = new DeleteBook();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }
        private void AddBook_Click(object sender, EventArgs e)
        {
            AddBook x = new AddBook();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }
        private void Logout_admin_Click(object sender, EventArgs e)
        {
            Login x = new Login();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }
        private void Edit_info_Click(object sender, EventArgs e)
        {
            Setting mysettings = new Setting();
            mysettings.Show();
        }
        private void AdminDgridvLibrarybooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && AdminDgridvLibrarybooks.Columns[e.ColumnIndex].Name == "Update")
            {
                UpdateBook updatebook = new UpdateBook();
                updatebook.Show();
                int book_ID = int.Parse(AdminDgridvLibrarybooks.Rows[e.RowIndex].Cells[1].Value.ToString());
                updatebook.LoadBookInfo(book_ID);
            }
        }
        private void Update_book_admin_Click(object sender, EventArgs e)
        {

        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.Show();
        }
    }
}
