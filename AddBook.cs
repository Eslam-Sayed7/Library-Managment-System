﻿using System;
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

namespace Library_Managment_System
{
    public partial class AddBook : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public AddBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool isNum(string x)
        {
            for (int i = 0; i < x.Length; ++i)
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
            bool k = true;
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("The BookID is required");
                k = false;
            }
            if (string.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                MessageBox.Show("The Title is required");
                k = false;

            }
            if (string.IsNullOrEmpty(textBox3.Text.Trim()))
            {
                MessageBox.Show("The ISBN is required");
                k = false;

            }
         
            if (string.IsNullOrEmpty(textBox4.Text.Trim()))
            {
                MessageBox.Show("The CategoryID is required");
                k = false;

            }
            if (string.IsNullOrEmpty(textBox5.Text.Trim()))
            {
                MessageBox.Show("The Publication is required");
                k = false;

            }
            if (string.IsNullOrEmpty(textBox6.Text.Trim()))
            {
                MessageBox.Show("The Description is required");
                k = false;

            }
            if (string.IsNullOrEmpty(textBox7.Text.Trim()))
            {
                MessageBox.Show("The Edition is required");
                k = false;

            }
            if (string.IsNullOrEmpty(textBox8.Text.Trim()))
            {
                MessageBox.Show("The AurthorID is required");
                k = false;

            }
            if (string.IsNullOrEmpty(comboBox1.Text.Trim()))
            {
                MessageBox.Show("The Availability is required");
                k = false;

            }

            if (k)
            {
                string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\Body\Library-Managment-System\libraryDB\LiveLibraryDB.mdf; Integrated Security = True; Connect Timeout = 30";
                con = new SqlConnection(connectionString);
                SqlConnection con2 = new SqlConnection(connectionString);
                con.Open();
                con2.Open();
                cmd = new SqlCommand("insert into books(bookId,title,isbn,categoryId,publicationYear,availability,description,edition,authorId)" +
                    "values(@bookId,@title,@isbn,@categoryId,@publicationYear,@availability,@description,@edition,@authorId);", con);

                SqlCommand cmd2 = new SqlCommand("select bookId from books " +
                    "where bookId=" + int.Parse(textBox1.Text), con2);
                // Check the BookId in the database
                cmd2.Parameters.AddWithValue("@bookId", int.Parse(textBox1.Text));
                SqlDataReader reader = cmd2.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    int retrievedBookId = reader.GetInt32(0);
                    if (retrievedBookId == int.Parse(textBox1.Text))
                    {
                        MessageBox.Show("You Entered an existing id  :\\");
                        return;
                    }

                }
                reader.Close();
                con2.Close();
                cmd.Parameters.AddWithValue("@bookId", int.Parse(textBox1.Text));
                //=============================================================

                cmd.Parameters.AddWithValue("@title", textBox2.Text);
                //=============================================================
                cmd.Parameters.AddWithValue("@isbn", textBox3.Text);
                //=============================================================
                cmd.Parameters.AddWithValue("@categoryId", int.Parse(textBox4.Text));
                //=============================================================
                if (isNum(textBox5.Text))
                {
                    cmd.Parameters.AddWithValue("@publicationYear", textBox5.Text);
                }
                else
                {
                    MessageBox.Show("Enter a Year :(");
                    return;
                }
                //=============================================================
                if (comboBox1.Text == "Yes")
                {
                    cmd.Parameters.AddWithValue("@availability", 1);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@availability", 0);
                }
                //=============================================================

                cmd.Parameters.AddWithValue("@description", textBox6.Text);
                //=============================================================

                cmd.Parameters.AddWithValue("@edition", textBox7.Text);
                //=============================================================


                cmd.Parameters.AddWithValue("@authorId", int.Parse(textBox8.Text));
                //=============================================================

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added Book Succesfully");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
