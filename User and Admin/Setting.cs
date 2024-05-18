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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();

            string GetUserIdQuery = "SELECT firstName, lastName, phone, email, homeAddress, password, isAdmin FROM users WHERE UserId = @userId";

            DBConnect Dbconect = new DBConnect();
            using (SqlConnection connection = new SqlConnection(Dbconect.myConnection()))
            {
                using (SqlCommand command = new SqlCommand(GetUserIdQuery, connection))
                {
                    int userId = GlobalVariables.GlobalVariables.uid;
                    command.Parameters.AddWithValue("@userId", userId);
                    

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        first_name_text_box.Text = reader["firstName"].ToString();
                        last_name_text_box.Text = reader["lastName"].ToString();
                        home_address_text_box.Text = reader["homeAddress"].ToString();
                        phone_text_box.Text = reader["phone"].ToString();
                        email_text_box.Text = reader["email"].ToString();
                        password_text_box.Text = reader["password"].ToString();
                    }
                    reader.Close();
                }
            }
        }   

        private void Setting_Load(object sender, EventArgs e)
        {
         
        }

        private void Lbl_lgnToaccount_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool flag = true;
            if (  string.IsNullOrEmpty(first_name_text_box.Text.Trim())
                ||string.IsNullOrEmpty(last_name_text_box.Text.Trim())
                ||string.IsNullOrEmpty(home_address_text_box.Text.Trim())
                ||string.IsNullOrEmpty(phone_text_box.Text.Trim())
                ||string.IsNullOrEmpty(email_text_box.Text.Trim())
                ||string.IsNullOrEmpty(password_text_box.Text.Trim()))
            {
                flag = false;
            }

            if (flag)
            {
                try
                {
                    string updateQuery = "UPDATE users " +
                                         "SET firstName = @firstname, lastName = @lastname, homeAddress = @homeadderss, phone = @phone1, email = @email1, password = @password1, isAdmin = @isAdmin1 " +
                                         "WHERE UserId = @userId";
                    DBConnect Dbconect = new DBConnect();
                    using (SqlConnection connection = new SqlConnection(Dbconect.myConnection()))
                    {
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@userId", GlobalVariables.GlobalVariables.uid);

                            command.Parameters.AddWithValue("@firstname", first_name_text_box.Text);
                            command.Parameters.AddWithValue("@lastname", last_name_text_box.Text);
                            command.Parameters.AddWithValue("@homeadderss", home_address_text_box.Text);
                            command.Parameters.AddWithValue("@phone1", phone_text_box.Text);
                            command.Parameters.AddWithValue("@email1", email_text_box.Text);
                            command.Parameters.AddWithValue("@password1", password_text_box.Text);

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
            else
            {
                MessageBox.Show("Invalid information");
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            { 
                password_text_box.UseSystemPasswordChar = false;
            }
            else
            {
                password_text_box.UseSystemPasswordChar = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
