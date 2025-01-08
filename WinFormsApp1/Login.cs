using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        //bool Exit = false;
        public Login()

        {
            InitializeComponent();
        }

        private void linkLabelRegisterPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Register = new Register();
            Register.Show();
            this.Close();
            //Exit = false;
        }

        private void linkLabelForgotPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ForgotPW = new Password();
            ForgotPW.Show();
            this.Close();
            //Exit = false;
        }

        //Enable or disable this to make the application exit upon closing the form//
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (!Exit)
            //{
            //    Application.Exit();
            //}
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string Email = textBoxEmail.Text;
            string Password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter your email address");
                textBoxEmail.Focus();
            }
            else if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Please enter your password");
                textBoxPassword.Focus();
            }
            else
            {
                ValidateUser(Email, Password);
                //var HomePage = new Home();
                //HomePage.Show();
                //this.Close();
                //Exit = false;
            }
        }
        private void ValidateUser(string Email, string Password)
        {
            var context = new MusicDBContext();

            var validate = from e in context.Users
                           where e.Email == Email && e.Password == Password
                           select e;

            if (validate.Count() != 0)
            {
                var HomePage = new Home();
                HomePage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email or Password is invalid. Please try again.");
                textBoxEmail.Clear();
                textBoxPassword.Clear();
                textBoxEmail.Focus();
            }
            //using (var context = new MusicDBContext())
            //{
            //    var email = context.Users
            //        .Where(e => Email.Contains(Email))
            //        .ToList();
            //    if (email.Any())
            //    {
            //        var HomePage = new Home();
            //        HomePage.Show();
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("There is no account associated with that email. Please try again or register a new account.");
            //    }

            //    var password = context.Users
            //        .Where(u => Password.PContains(Password))
            //        .ToList();
            //    if (password.Any())
            //    {
            //        var HomePage = new Home();
            //        HomePage.Show();
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Password is incorrect. Please try again.");
            //    }
            //}
        }

        private void labelLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
