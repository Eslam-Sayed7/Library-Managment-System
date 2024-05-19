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
using System.Data.SqlClient;
using System.Data.Sql;
namespace Library_Managment_System
{
    public partial class DeleteBook : Form
    {
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool isDigit(string  x)
        {
            for(int i=0; i <x.Length; i++)
            {
                if (x[i] < '0' || x[i] > '9')
                {
                    return false;
                }
            }
            return true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string conncetion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= D:\CS\2 - Second year\[2] Second term\DataBases\Project\Library Managment System\libraryDB\LiveLibraryDB.mdf;Integrated Security=False;Connect Timeout=30;";
            SqlConnection con = new SqlConnection(conncetion);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            if (isDigit(textBox1.Text))
            {
                try{
                    string sql = "delete books where bookId = " + int.Parse(textBox1.Text);
                    cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("The book Has been Deleted");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("the book is ordered you cannot remove it");
                    return;
                }
            }
            else
            {
                MessageBox.Show("not a valid ID");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHome x = new AdminHome();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }
    }
}
