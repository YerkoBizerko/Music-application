using Microsoft.EntityFrameworkCore;
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
    public partial class DeleteAcc : Form
    {
        public DeleteAcc()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdatePwConfirmBtn_Click(object sender, EventArgs e)
        {
            string Pw = PwTextBox.Text;
            string Email = EmailTextbox.Text;

            if (string.IsNullOrWhiteSpace(EmailTextbox.Text))
            {
                MessageBox.Show("Please enter your previous email address");
                EmailTextbox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(PwTextBox.Text))
            {
                MessageBox.Show("Please enter your new email address");
                PwTextBox.Focus();
            }
            else if (DeactivateCheckbox.Checked == false)
            {
                MessageBox.Show("Please click the checkbox to continue");
                DeactivateCheckbox.Focus();
            }
            else
            {
                DeactivateAcc(Email, Pw);
            }
        }

        private void DeactivateAcc(string Email, string Pw)
        {
            var context = new MusicDBContext();

            var accountMatch = from a in context.Users
                               where a.Email == Email && a.Password == Pw
                               select a;

            if (accountMatch.Count() != 0)
            {
                context.Users.Where(e => e.Email == Email).ExecuteDelete();
                MessageBox.Show("Your account has been deactvated. Close this message to exit the application.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Email or password is invalid. Please try again.");
                EmailTextbox.Clear();
                PwTextBox.Clear();
                EmailTextbox.Focus();
            }
        }
    }
}
