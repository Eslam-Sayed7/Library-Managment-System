using LiveLibraryDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Managment_System
{
    public partial class Login : Form
    {
        private int LogginID;
        public Login()
        {
            InitializeComponent();
            
        }
        public void Login_Load(object sender, EventArgs e)
        {

        }
        private int GetUserId(string email, string password)
        {
            if (email == null || password == null) { return -1; }
            string GetUserIdQuery = "SELECT UserId FROM users WHERE Email = @email AND Password = @password";
            
            DBConnect Dbconect = new DBConnect();
            using (SqlConnection connection = new SqlConnection(Dbconect.myConnection()))
            {
                using (SqlCommand command = new SqlCommand(GetUserIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    return (Convert.ToInt32(command.ExecuteScalar()));
                }
            }
        }
        private bool IsUserExists(string email, string password)
        {
            if (email == null || password == null) { return false; }

            string query = "SELECT 1 FROM users WHERE Email = @Email AND Password = @Password";

            DBConnect Dbconect = new DBConnect();
            using (SqlConnection connection = new SqlConnection(Dbconect.myConnection()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    return command.ExecuteScalar() != null;
                }
            }
        }
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string email = Emailtxtbox.Text;
            string password = PasswordtextBox.Text;

            try
            {
                bool isValid = IsUserExists(email, password);
                if (isValid)
                {
                    /*MessageBox.Show("Your are a user in the system");*/
                    GlobalVariables.GlobalVariables.uid = GetUserId(email, password);
                    /*Mybooks mybooks = new Mybooks(GlobalVariables.GlobalVariables.uid);
                    mybooks.Show();*/
                    MainForm mainForm = new MainForm(GlobalVariables.GlobalVariables.uid);
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid email/password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Lbl_lgnToaccount_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}