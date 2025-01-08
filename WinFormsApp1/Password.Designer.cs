namespace WinFormsApp1
{
    partial class Password
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password));
            labelPassword = new Label();
            labelPWtext = new Label();
            linkLabelLoginPage = new LinkLabel();
            textBoxPWreset = new TextBox();
            buttonPWreset = new Button();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = SystemColors.ControlLightLight;
            labelPassword.Location = new Point(319, 271);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(261, 40);
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Forgot password?";
            // 
            // labelPWtext
            // 
            labelPWtext.AutoSize = true;
            labelPWtext.ForeColor = SystemColors.ControlLightLight;
            labelPWtext.Location = new Point(324, 376);
            labelPWtext.Name = "labelPWtext";
            labelPWtext.Size = new Size(251, 15);
            labelPWtext.TabIndex = 1;
            labelPWtext.Text = "Please enter your email to reset your password";
            // 
            // linkLabelLoginPage
            // 
            linkLabelLoginPage.AutoSize = true;
            linkLabelLoginPage.LinkColor = Color.White;
            linkLabelLoginPage.Location = new Point(413, 607);
            linkLabelLoginPage.Name = "linkLabelLoginPage";
            linkLabelLoginPage.Size = new Size(76, 15);
            linkLabelLoginPage.TabIndex = 2;
            linkLabelLoginPage.TabStop = true;
            linkLabelLoginPage.Text = "Back to login";
            linkLabelLoginPage.LinkClicked += linkLabelLoginPage_LinkClicked;
            // 
            // textBoxPWreset
            // 
            textBoxPWreset.BackColor = SystemColors.GrayText;
            textBoxPWreset.BorderStyle = BorderStyle.FixedSingle;
            textBoxPWreset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPWreset.ForeColor = SystemColors.ControlLightLight;
            textBoxPWreset.Location = new Point(330, 404);
            textBoxPWreset.Name = "textBoxPWreset";
            textBoxPWreset.Size = new Size(239, 29);
            textBoxPWreset.TabIndex = 3;
            // 
            // buttonPWreset
            // 
            buttonPWreset.BackColor = SystemColors.GrayText;
            buttonPWreset.ForeColor = SystemColors.ControlLightLight;
            buttonPWreset.Location = new Point(377, 468);
            buttonPWreset.Name = "buttonPWreset";
            buttonPWreset.Size = new Size(152, 47);
            buttonPWreset.TabIndex = 4;
            buttonPWreset.Text = "Send Reset Link";
            buttonPWreset.UseVisualStyleBackColor = false;
            buttonPWreset.Click += buttonPWreset_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(362, 18);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(174, 179);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 25;
            pictureBoxLogo.TabStop = false;
            // 
            // Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(901, 771);
            Controls.Add(pictureBoxLogo);
            Controls.Add(buttonPWreset);
            Controls.Add(textBoxPWreset);
            Controls.Add(linkLabelLoginPage);
            Controls.Add(labelPWtext);
            Controls.Add(labelPassword);
            Name = "Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPassword;
        private Label labelPWtext;
        private LinkLabel linkLabelLoginPage;
        private TextBox textBoxPWreset;
        private Button buttonPWreset;
        private PictureBox pictureBoxLogo;
    }
}