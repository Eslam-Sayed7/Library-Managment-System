﻿using System;
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
    public partial class MainForm : Form
    {
        SqlConnection Con = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        DBConnect Dbconect = new DBConnect();

        public MainForm(int uid)
        {
            /*label_user_name.Text = "user name : " + uid.ToString();*/
            InitializeComponent();
            Con = new SqlConnection(Dbconect.myConnection());
            Con.Open();
           // MessageBox.Show("Database is connected");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_My_books_Click(object sender, EventArgs e)
        {
            Mybooks mybooks = new Mybooks(GlobalVariables.GlobalVariables.uid);
            mybooks.Show();
        }

        private void button1_Click(object sender, EventArgs e) //
        {
            Login x = new Login();
            this.Hide();
            x.ShowDialog();
            this.Close();

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

        private void btn_settings_Click_1(object sender, EventArgs e)
        {
        }

        private void panel_main_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
