using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            //automatically generates captcha//
            generateCaptcha();

        }
        //link to login page from register link label//
        private void linkLabelLoginPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Login = new Login();
            Login.Show();
            this.Close();
        }

        //this section includes empty validations//
        private void buttonCreateAcc_Click(object sender, EventArgs e)
        {

            string FN = textBoxFirstName.Text;
            string LN = textBoxLastName.Text;
            string Email = textBoxEmail.Text;
            string Password = textBoxPassword.Text;


            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                MessageBox.Show("Please enter a First Name.");
                textBoxFirstName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show("Please enter a Last Name.");
                textBoxLastName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter an Email.");
                textBoxEmail.Focus();
            }
            else if (!Regex.Match(textBoxEmail.Text, "^((\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)\\s*[;]{0,1}\\s*)+$").Success)
            {
                MessageBox.Show("That is not a valid Email format. Try again");
                textBoxEmail.Focus();
            }
            else if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Please enter a Password.");
                textBoxPassword.Focus();
            }
            else if (textBoxCaptcha.Text != labelCaptchaBox.Text)
            {
                MessageBox.Show("CAPTCHA is incorrect, Please try again.");
                textBoxCaptcha.Focus();
                textBoxCaptcha.Clear();
                generateCaptcha();
            }
            else if (checkBoxPolicy.Checked == false)
            {
                MessageBox.Show("Please accept our Privacy Policy to continue.");
                checkBoxPolicy.Focus();
            }
            else
            {
                //validation that new email is not already registered to an account. Will add new user if not in database//
                using (var context = new MusicDBContext())
                {
                    var u = new User();
                    u.First_Name = FN;
                    u.Last_Name = LN;
                    u.Email = Email;
                    u.Password = Password;

                    var existingRecord = context.Users.FirstOrDefault(u => u.Email == Email);
                    if (existingRecord != null)
                    {
                        MessageBox.Show("This Email is already registered. Please use a different email or click Forgot password");
                        textBoxEmail.Focus();
                    }
                    else
                    {
                        context.Users.Add(u);
                        context.SaveChanges();
                        MessageBox.Show("Your account has been created!\n Please log in using your credentials.");
                        var Login = new Login();
                        Login.Show();
                        this.Close();
                    }
                }
                //This is the old method of adding a new user. un-comment to re-enable and comment out the above code.//

                //AddUser(FN,LN,Email,Password);
                //MessageBox.Show("Your account has been created!\n Please log in using your credentials.");
                //var Login = new Login();
                //Login.Show();
                //this.Close();
  
            }
        }

        //private void AddUser(string FN, string LN, string Email, string Password) THIS IS THE METHOD OUTLINED ABOVE. UN-COMMENT TO UTILIZE//
        //{
        //    using (var context = new MusicDBContext())
        //    {
        //        var u = new User();
        //        u.First_Name = FN;
        //        u.Last_Name = LN;
        //        u.Email = Email;
        //        u.Password = Password;

        //        var existingRecord = context.Users.FirstOrDefault(u => u.Email == Email);
        //        if (existingRecord != null)
        //        {
        //            MessageBox.Show("This Email is already registered. Please use a different email or click Forgot password");
        //            textBoxEmail.Focus();
        //        }
        //        //if (context.Users.Any(u => u.Email == User.Email))
        //        else
        //        {
        //            context.Users.Add(u);
        //            context.SaveChanges();
        //        }
        //    }
        //}
        private void generateCaptcha()
        {
            Random random = new Random();
            int num = random.Next(6, 8);
            string captcha = "";
            int total = 0;

            do
            {
                //numbers represent ASCII system
                int chr = random.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha = captcha + (char)chr;
                    total++;
                    if (total == num)
                    {
                        break;
                    }
                }
            }
            while (true);
            labelCaptchaBox.Text = captcha;
        }


        private void buttonNewCaptcha_Click(object sender, EventArgs e)
        {
            generateCaptcha();
        }
    }
}
