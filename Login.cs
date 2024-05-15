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
using System.Runtime.Remoting.Messaging;
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
        public Login(string email, string password)
        {
            InitializeComponent();
            LoginValidation(email, password);
        }
        private void SetLogginID(int LogginID)
        {
            GlobalVariables.GlobalVariables.uid = LogginID;
        }
        public void Login_Load(object sender, EventArgs e) // need to be deleted 
        {

        }
        private int GetUserIdFromCredentials(string email, string password)
        {
            if (email == null || password == null) { return -1; }
            string GetUserIdFromCredentialsQuery = "SELECT UserId FROM users WHERE Email = @email AND Password = @password";
            
            DBConnect Dbconect = new DBConnect();
            using (SqlConnection connection = new SqlConnection(Dbconect.myConnection()))
            {
                using (SqlCommand command = new SqlCommand(GetUserIdFromCredentialsQuery, connection))
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
        private void LoginValidation(string email, string password)
        {
            try
            {
                bool isValid = IsUserExists(email, password);
                if (isValid)
                {
                    SetLogginID(GetUserIdFromCredentials(email, password));
/*                    Emailtxtbox.Clear();*/
 /*                   PasswordtextBox.Clear();*/
                    this.Hide();
                    MainForm mainForm = new MainForm(GlobalVariables.GlobalVariables.uid);
                    mainForm.Show();
                    this.Close();
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
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string email = Emailtxtbox.Text;
            string password = PasswordtextBox.Text;
            LoginValidation(email, password);
        }

        private void Lbl_lgnToaccount_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}