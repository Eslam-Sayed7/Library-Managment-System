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
using LiveLibraryDB;


namespace Library_Managment_System
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        DBConnect Dbconect = new DBConnect();

        public Form1()
        {
            InitializeComponent();
            Con = new SqlConnection(Dbconect.myConnection());
            Con.Open();
            MessageBox.Show("Database is connected");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_My_books_Click(object sender, EventArgs e)
        {
            Application.Run(new Mybooks());
        }

        private void button1_Click(object sender, EventArgs e) // logout btn
        {
            // logging out from the global logged user 
        
        }


        private void btn_favorite_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel_window_title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_settings_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
