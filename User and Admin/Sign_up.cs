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
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Library_Managment_System
{
    public partial class Sign_up : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        public Sign_up()
        {
            InitializeComponent();
        }
        private bool isDigit(char digit)
        {
            if (digit < '0' || digit > '9')
            {
                return false;
            }
            return true;
        }
        private bool isVaildPhone(string phone)
        {
            for (int i = 0; i < phone.Length; ++i)
            {
                if ((i == 0 && phone[i] == '+') || isDigit(phone[i]))
                {
                    continue;
                }
                return false;
            }
            return true;
        }
        //for Email Checking 
        private bool checkEmail(string email)
        {
            if (email.Contains('@'))
                return true;
            return false;
        }
        private void button1_Click(object sender, EventArgs e) // sign up button
        {
            bool k = true;
            if (string.IsNullOrEmpty(FirstNameTextBox.Text.Trim()))
            {
                MessageBox.Show("The firstName is Empty");
                k = false;
            }
            if (string.IsNullOrEmpty(LastNameTextBox.Text.Trim()))
            {
                MessageBox.Show("The lastName is Empty");
                k = false;

            }
            if (string.IsNullOrEmpty(textBox3.Text.Trim()))
            {
                MessageBox.Show("The homeAddress is Empty");
                k = false;

            }
            if (string.IsNullOrEmpty(textBox4.Text.Trim()))
            {
                MessageBox.Show("The Phone is Empty");
                k = false;

            }
            if (string.IsNullOrEmpty(EmailSignupTextBox.Text.Trim()))
            {
                MessageBox.Show("The Email is Empty");
                k = false;

            }
            if (string.IsNullOrEmpty(PasswordSignUpTxtBox.Text.Trim()))
            {
                MessageBox.Show("The Password is Empty");
                k = false;
            }
            if (string.IsNullOrEmpty(IsAdmincomboBox1.Text.Trim()))
            {
                MessageBox.Show("This field is required");
                k = false;
            }
            if (k)
            {
                //change the path on your local computer 

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\CS\2 - Second year\[2] Second term\DataBases\Project\Library Managment System\libraryDB\LiveLibraryDB.mdf"";Integrated Security=False;Connect Timeout=30;";
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("insert into users(firstName,lastName,homeAddress,phone,email,password,isAdmin)values(@firstName,@lastName,@homeAddress,@phone,@email,@password,@isAdmin);", con);
                cmd.Parameters.AddWithValue("@firstName", FirstNameTextBox.Text);
                cmd.Parameters.AddWithValue("@lastName", LastNameTextBox.Text);
                cmd.Parameters.AddWithValue("@homeAddress", textBox3.Text);
                /*==========================================================================================*/
                //checking the phone 
                if (isVaildPhone(textBox4.Text))
                {
                    cmd.Parameters.AddWithValue("@phone", textBox4.Text);
                }
                else
                {
                    MessageBox.Show("Invalid Phone number :/");
                    return;
                }
                //end of the check
                /*==========================================================================================*/
                //checking the email 
                if (checkEmail(EmailSignupTextBox.Text))
                {
                    cmd.Parameters.AddWithValue("@email", EmailSignupTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Invalid Email:/");
                    return;
                }
                //end of the check
                /*==========================================================================================*/
                cmd.Parameters.AddWithValue("@password", PasswordSignUpTxtBox.Text);
                if (IsAdmincomboBox1.Text == "Yes")
                {
                    cmd.Parameters.AddWithValue("@isAdmin", 1);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@isAdmin", 0);
                }
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Congratulations You have been successfully registered :)");
               
            }
            else
            {
                return;
            }
        }
        //Check Box
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                PasswordSignUpTxtBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordSignUpTxtBox.UseSystemPasswordChar = true;
            }
        }
        private void Login_click(object sender, EventArgs e)
        {
            Login newLogin = new Login();
            this.Hide();
            newLogin.ShowDialog();
            //this.Close();

        }
    }
}
