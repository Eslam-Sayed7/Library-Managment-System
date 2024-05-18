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

namespace Library_Managment_System.User_and_Admin
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }
        private bool isDigit(string x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < '0' || x[i] > '9')
                {
                    return false;
                }
            }
            return true;

        }

        private void button_deleteuserid_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();
            DBConnect Dbconect = new DBConnect();
            SqlDataReader dr;

            con = new SqlConnection(Dbconect.myConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            if (isDigit(UserIdtxtbox.Text))
            {
                string sql = "delete users where UserId = " + int.Parse(UserIdtxtbox.Text);

                con.Open();
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                adapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("The user has been Deleted");
                con.Close();
            }
            else
            {
                MessageBox.Show("not a valid ID");
                return;
            }
        }

        private void backtohome_Click(object sender, EventArgs e)
        {
            AdminHome newAdminHomeFromUserDeletions = new AdminHome();
            this.Hide();
            newAdminHomeFromUserDeletions.ShowDialog();
            this.Close();
        }
    }
}
