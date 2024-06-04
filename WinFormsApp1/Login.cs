using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (textBoxEmail.Text == "")
            {
                MessageBox.Show("Please enter your email address");
                textBoxEmail.Focus();
            }
            else if (textBoxPassword.Text =="")
            {
                MessageBox.Show("Please enter your password");
                textBoxPassword.Focus();
            }
            else
            {
                var HomePage = new Home();
                HomePage.Show();
                this.Close();
                //Exit = false;
            }
        }
    }
}
