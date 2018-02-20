using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text && textBox2.Text) //This is the Check to see if the Email And Password matches whats in the DB
            //{
             
            }*/
            if (textBox1.Text.Length > 0  && textBox2.Text.Length > 0)
            {
                this.Hide();
                Form3 f3 = new Form3(); // we will remove this once we get the database up and running.
                f3.ShowDialog(); //but this is just to check that we can load into the "app"
            }
            else
            {
                MessageBox.Show("Please Enter Your Email and or Password");
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //This Will Check If Email is on File
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //This will Check if password matches that of email 
        }
        //Both of the above will display that same "Your Email or Password is incorrect" message
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            // This Will load the Sign-Up Window
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
