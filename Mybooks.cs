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
    public partial class Mybooks : Form
    {
        SqlConnection Con = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        DBConnect Dbconect = new DBConnect();

        public Mybooks()
        {
            InitializeComponent();
            Con = new SqlConnection(Dbconect.myConnection());
              
        }
        public void LoadData()
        {
            Con.Open();
            Cmd = new SqlCommand("select [borrowingTtransaction][title][categoryId][isbn][returnDate] from Books bk join borrow bw on bk.bookId = bw.bookId where bw.userId = @LogginID", Con);
            Cmd.Parameters.AddWithValue("@uid", Login.userIdtxtbox.Text);
            Cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("User data loaded successfully" , "");
        }
    }
}
