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
using System.Net.Mail;
using System.ComponentModel.Design;

namespace WindowsFormsApp1
{
    /* Note: This is Just a very very basic mockup I just want to get a rough baseline
     * Note 2: Unsure if you would like an age im assuming so but i havent included it yet,
     * Note 3: As stated in previous comment this is basic as i'm just aiming to achieve basic functionality
     * and get a rough idea of what I feel you're aiming for from what you've described to me
     */
     class ValidateSomeEmails
    {
        static void Main(string[] Args)
        {
            var val = new EmailAddressAttribute();
            bool bar;
            bar = val.IsValid("testemail@testhost.com");        //true
            bar = val.IsValid("testemail@testhost.co.uk");      //true
            bar = val.IsValid("testemail+tag@testhost.net");    //true
            bar = val.IsValid("testEMAIL@testhost.foooo");      //true

            bar = val.IsValid("test");          //false
            bar = val.IsValid("test@");         //false
            bar = val.IsValid("test@test");     //false
            bar = val.IsValid("test@test.");    // false
            /*Note: This ASpect is Missing the System.ComponentModel.DataAnnotations aspect which for 
             * some reason isnt loaded on this computer however if you could implement that aspect
             * by typing "using System.ComponentModel.DataAnnotations" then this shoud work you 
             * may also want to add the aspect into the check or try the way that i ahve implemented
             * below as both should work perfectly fine.
            */
        }
    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 7)
            {
                MessageBox.Show("This password does not meet the 7 character check");
            }
            else
            {
                //this is where we would add a check to see if the password contains repeating patterns
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           if(textBox1.Text == textBox2.Text)
            {
                //this is where we add data to the database using system data SQL
            }
            else
            {
                MessageBox.Show("The Two Passwords Do Not Match");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            /*bool IsEmailValid(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
               
            }
            IsEmailValid(string mail); */
        }
    }
}
