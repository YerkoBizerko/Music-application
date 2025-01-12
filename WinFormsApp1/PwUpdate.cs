using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class PwUpdate : Form
    {
        public PwUpdate()
        {
            InitializeComponent();
        }

        private void UpdatePwConfirmBtn_Click(object sender, EventArgs e)
        {
            string Pw = OldPwTextBox.Text;
            string Email = EmailTextbox.Text;

            if (string.IsNullOrWhiteSpace(EmailTextbox.Text))
            {
                MessageBox.Show("Please enter your previous email address");
                EmailTextbox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(NewPwTextBox2.Text))
            {
                MessageBox.Show("Please enter your new email address");
                NewPwTextBox2.Focus();
            }
            else if (PwConfirmationCheckbox.Checked == false)
            {
                MessageBox.Show("Please click the checkbox to continue");
                PwConfirmationCheckbox.Focus();
            }
            else
            {
                ChangePw(Email, Pw);
            }
        }

        private void ChangePw(string Email, string Pw)
        {
            var context = new MusicDBContext();

            var accountMatch = from a in context.Users
                               where a.Email == Email && a.Password == Pw
                               select a;

            if (accountMatch.Count() != 0)
            {
                var NewPw = NewPwTextBox2.Text;

                context.Users.Where(p => p.Password == Pw).ExecuteUpdate(setters => setters.SetProperty(p => p.Password, NewPw));
                MessageBox.Show("Your password has been changed successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Email or password is invalid. Please try again.");
                EmailTextbox.Clear();
                OldPwTextBox.Clear();
                NewPwTextBox2.Clear();
                EmailTextbox.Focus();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
