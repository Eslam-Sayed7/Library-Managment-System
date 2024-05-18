using LiveLibraryDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Managment_System.BookActions
{
    public partial class BorrowAction : Form
    {
        public BorrowAction()
        {
            InitializeComponent();
        }
        private bool IsUserAdmin(int _USERID_)
        {
            string query = "SELECT 1 FROM users WHERE userId = @USERID AND isAdmin = 1";

            DBConnect Dbconect = new DBConnect();
            using (SqlConnection connection = new SqlConnection(Dbconect.myConnection()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@USERID", _USERID_);

                    connection.Open();
                    return command.ExecuteScalar() != null;
                }
            }
        }
        private bool bookExist(int _bookid_)
        {
            string query = "SELECT 1 FROM books WHERE bookId = @BOOKID ";

            DBConnect Dbconect = new DBConnect();
            using (SqlConnection connection = new SqlConnection(Dbconect.myConnection()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BOOKID", _bookid_);

                    connection.Open();
                    return command.ExecuteScalar() != null;
                }
            }
        }
        private void borrowBtn_Click(object sender, EventArgs e)
        {
            bool user_is_admin = IsUserAdmin(int.Parse(UserIdToBorrow.Text));
            bool book_Exist = bookExist(int.Parse(bookIdToBorrow.Text));
            if (!user_is_admin && book_Exist)
            {
                try
                {
                    DBConnect Dbconect = new DBConnect();

                    using (SqlConnection connection = new SqlConnection(Dbconect.myConnection()))
                    {
                        string borrowsqlquery = "INSERT INTO dbo.borrow (bookId, userId, borrowDate, returnDate) " +
                                                               "VALUES (@BookId, @UserId, GETDATE(), DATEADD(DAY, 7, GETDATE())); ";
                        using (SqlCommand makeborrow = new SqlCommand(borrowsqlquery, connection))
                        {
                            makeborrow.Parameters.AddWithValue("@BookId", int.Parse(bookIdToBorrow.Text));
                            makeborrow.Parameters.AddWithValue("@UserId", int.Parse(UserIdToBorrow.Text));
                            connection.Open();
                            int rowsAffected = makeborrow.ExecuteNonQuery();
                            MessageBox.Show(rowsAffected + " row(s) updated.");

                        }
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error with borrowing action " + ex.Message);

                }
            }
            else
            {
                if (user_is_admin)
                {
                    MessageBox.Show("this user cannot borrow ");
                }
                else
                {
                    MessageBox.Show("This bookId does not exist");
                }
            }
        }               

        private void RtrnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome newAdminHome = new AdminHome();
            newAdminHome.ShowDialog();
            this.Close();
        }
    }

}
