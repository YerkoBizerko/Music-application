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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class EmailUpdate : Form
    {
        public EmailUpdate()
        {
            InitializeComponent();
        }

        private void UpdateEmailConfirmBtn_Click(object sender, EventArgs e)
        {
            string Email = OldEmailTextbox.Text;

            if (string.IsNullOrWhiteSpace(OldEmailTextbox.Text))
            {
                MessageBox.Show("Please enter your previous email address");
                OldEmailTextbox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(NewEmailTextBox2.Text))
            {
                MessageBox.Show("Please enter your new email address");
                NewEmailTextBox2.Focus();
            }
            else if (!Regex.Match(NewEmailTextBox2.Text, "^((\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)\\s*[;]{0,1}\\s*)+$").Success)
            {
                MessageBox.Show("That is not a valid Email format. Try again");
                NewEmailTextBox2.Focus();
            }
            else if (EmailConfirmationCheckbox.Checked == false)
            {
                MessageBox.Show("Please click the checkbox to continue");
                EmailConfirmationCheckbox.Focus();
            }
            else
            {
                UpdateValidEmail(Email);
            }
        }

        private void UpdateValidEmail(string Email)
        {
            var context = new MusicDBContext();

            var validate = from e in context.Users
                           where e.Email == Email
                           select e;

            if (validate.Count() != 0)
            {
                var NewEmail = NewEmailTextBox2.Text;

                context.Users.Where(e => e.Email == Email).ExecuteUpdate(setters => setters.SetProperty(e => e.Email, NewEmail));
                MessageBox.Show("Your email address has been updated successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Email is invalid. Please try again.");
                OldEmailTextbox.Clear();
                OldEmailTextbox.Focus();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
