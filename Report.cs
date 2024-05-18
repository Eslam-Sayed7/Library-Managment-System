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

    public partial class Report : Form
    {
        SqlConnection Con = new SqlConnection();
        SqlCommand mostborrowedquery = new SqlCommand();
        SqlCommand UsersNumberquery = new SqlCommand();
        SqlCommand BooksNumberquery = new SqlCommand();
        DBConnect Dbconect = new DBConnect();
        SqlDataReader dr;

        public Report()
        {
            InitializeComponent();
            Con = new SqlConnection(Dbconect.myConnection());
            loadReport();
        }
        public void loadReport()
        {
            Con.Open();
            SqlCommand mostborrowedquery = new SqlCommand(
                "SELECT TOP 1 " +
                "b.title, " +
                "COUNT(br.bookId) AS BorrowCount " +
                "FROM dbo.borrow br " +
                "JOIN dbo.books b " +
                "ON br.bookId = b.bookId " +
                "GROUP BY b.title " +
                "ORDER BY BorrowCount DESC", Con);
            SqlCommand userCountQuery = new SqlCommand("SELECT COUNT(*) AS NumberOfUsers " +
                                                       "FROM dbo.users", Con);
            SqlCommand bookCountQuery = new SqlCommand("SELECT COUNT(*) AS NumberOfBooks " +
                                                       "FROM dbo.books", Con);

            SqlDataReader dr = mostborrowedquery.ExecuteReader();
            if (dr.Read())  // Ensure there's data to read
            {
                MostBorrowedBook.Text = dr["title"].ToString();
            }
            else
            {
                MostBorrowedBook.Text = "No data available";  // Handle the case with no data
            }
            dr.Close();
            
            dr = userCountQuery.ExecuteReader();
            if (dr.Read())  // Ensure there's data to read
            {
                Users_Number.Text = dr["NumberOfUsers"].ToString();
            }
            else
            {
                Users_Number.Text = "No data available";  // Handle the case with no data
            }
            dr.Close();

            dr = bookCountQuery.ExecuteReader();
            if (dr.Read())  // Ensure there's data to read
            {
                BooksNumber.Text = dr["NumberOfBooks"].ToString();
            }
            else
            {
                BooksNumber.Text = "No data available";  // Handle the case with no data
            }
            dr.Close();
            Con.Close();
        }


    }
}
