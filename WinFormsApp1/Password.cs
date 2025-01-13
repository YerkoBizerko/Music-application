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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void linkLabelLoginPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Login = new Login();
            Login.Show();
            this.Close();
        }

        private void buttonPWreset_Click(object sender, EventArgs e)
        {
            if (textBoxPWreset.Text == "")
            {
                MessageBox.Show("Please enter your email address");
            }
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
