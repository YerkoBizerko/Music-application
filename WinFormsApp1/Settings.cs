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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void UpdateEmailBtn_Click(object sender, EventArgs e)
        {
            var EmailUpdate = new EmailUpdate();
            EmailUpdate.Show();
            this.Close();
        }

        private void ChangePwdBtn_Click(object sender, EventArgs e)
        {
            var PwUpdate = new PwUpdate();
            PwUpdate.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteAccBtn_Click(object sender, EventArgs e)
        {
            var DeleteAcc = new DeleteAcc();
            DeleteAcc.Show();
            this.Close();
        }
    }
}
