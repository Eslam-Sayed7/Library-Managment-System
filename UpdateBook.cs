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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library_Managment_System
{
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void LoadBookInfo(int _bookID_)
        {

            string getbookquery = "SELECT bookId ,title , isbn , categoryId , publicationYear , [availability] , [description] , edition , authorId "+
                                  "FROM   books " +
                                  "WHERE  bookId = @BOOKID";

            DBConnect Dbconect = new DBConnect();
            using (SqlConnection connection = new SqlConnection(Dbconect.myConnection()))
            {
                using (SqlCommand command = new SqlCommand(getbookquery, connection))
                {
                    command.Parameters.AddWithValue("@BOOKID", _bookID_);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        updateBookId.Text = reader["bookId"].ToString();
                        updateBookTitle.Text = reader["title"].ToString();
                        updateBookISBN.Text = reader["isbn"].ToString();
                        UpdateBookCatID.Text  = reader["categoryId"].ToString();
                        UpdateBookpubYr.Text = reader["publicationYear"].ToString();
                        updateDescBox.Text = reader["description"].ToString();
                        updateEdition.Text = reader["edition"].ToString();
                        updateAuthor.Text = reader["authorId"].ToString();
                        //AvailableBox1.SelectedIndex = int.Parse(reader["availability"].ToString()) - 1;
                        if (int.TryParse(reader["availability"].ToString(), out int availability))
                        {
                            AvailableBox1.SelectedIndex = availability - 1;
                        }
                        else
                        {
                            // Handle the case where availability is not a valid integer
                            AvailableBox1.SelectedIndex = -1; // or set to a default value
                        }
                    }
                    reader.Close();
                }
            }

        }
        public void SaveBookInfo()
        {
            bool EmptyFieldExist = false;
            if (string.IsNullOrEmpty(updateBookId.Text.Trim())
                || string.IsNullOrEmpty(updateBookTitle.Text.Trim())
                || string.IsNullOrEmpty(updateBookISBN.Text.Trim())
                || string.IsNullOrEmpty(UpdateBookCatID.Text.Trim())
                //|| string.IsNullOrEmpty(UpdateBookpubYr.Text.Trim())
                || string.IsNullOrEmpty(AvailableBox1.Text.Trim())
                || string.IsNullOrEmpty(updateDescBox.Text.Trim())
                || string.IsNullOrEmpty(updateEdition.Text.Trim())
                || string.IsNullOrEmpty(updateAuthor.Text.Trim()))
            {
                EmptyFieldExist = true;
            }

            if (EmptyFieldExist)
            {
                MessageBox.Show("Please fill all fields");
            }
            else // all fields contain data
            {
                try
                {
                    string updateQuery = "UPDATE books " +
                                         "SET bookId = @bookId, title = @title, isbn = @isbn, categoryId = @categoryId  , publicationYear = @publicationYear, [availability] = @availability, [description] = @description, edition = @edition, authorId = @authorId " +
                                         "WHERE bookId = @bookId";
                    DBConnect Dbconect = new DBConnect();
                    using (SqlConnection connection = new SqlConnection(Dbconect.myConnection()))
                    {
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@userId", GlobalVariables.GlobalVariables.uid);
                            command.Parameters.AddWithValue("@bookId", updateBookId.Text);
                            command.Parameters.AddWithValue("@title", updateBookTitle.Text);
                            command.Parameters.AddWithValue("@isbn", updateBookISBN.Text);
                            command.Parameters.AddWithValue("@categoryId", UpdateBookCatID.Text);
                            command.Parameters.AddWithValue("@publicationYear", UpdateBookpubYr.Text);
                            command.Parameters.AddWithValue("@availability", AvailableBox1.SelectedIndex ^ 1);
                            command.Parameters.AddWithValue("@edition", updateEdition.Text);
                            command.Parameters.AddWithValue("@description", updateDescBox.Text);
                            command.Parameters.AddWithValue("@authorId", updateAuthor.Text);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            MessageBox.Show(rowsAffected + " row(s) updated.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message);
                }
            }

        }

        private void Update_btn_click(object sender, EventArgs e)
        {
            SaveBookInfo();
        }

        private void CancelUpdate_Click(object sender, EventArgs e)
        {
               this.Close();
        }
    }
}
