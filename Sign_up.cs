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

        private void Sign_up_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_lgnToaccount_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

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
        private void button1_Click(object sender, EventArgs e)
        {
            bool k = true;
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("The firstName is Empty");
                k = false;
            }
            if (string.IsNullOrEmpty(textBox2.Text.Trim()))
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
            if (string.IsNullOrEmpty(textBox5.Text.Trim()))
            {
                MessageBox.Show("The Email is Empty");
                k = false;

            }
            if (string.IsNullOrEmpty(comboBox1.Text.Trim()))
            {
                MessageBox.Show("This field is required");
                k = false;
            }
            if (k)
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\CS\2 - Second year\[2] Second term\DataBases\Project\Library Managment System\libraryDB\LiveLibraryDB.mdf"";Integrated Security=True;Connect Timeout=30;");
                con.Open();
                cmd = new SqlCommand("insert into users(firstName,lastName,homeAddress,phone,email,isAdmin)values(@firstName,@lastName,@homeAddress,@phone,@email,@isAdmin);", con);
                cmd.Parameters.AddWithValue("@firstName", textBox1.Text);
                cmd.Parameters.AddWithValue("@lastName", textBox2.Text);
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
                if (checkEmail(textBox5.Text))
                {
                    cmd.Parameters.AddWithValue("@email", textBox5.Text);
                }
                else
                {
                    MessageBox.Show("Invalid Email:/");
                    return;
                }
                //end of the check
                /*==========================================================================================*/
                if (comboBox1.Text == "Yes")
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login x = new Login();
            this.Hide();
            x.ShowDialog();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
