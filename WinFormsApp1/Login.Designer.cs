namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBoxLogo = new PictureBox();
            labelLogo = new Label();
            labelHeading = new Label();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            labelEmail = new Label();
            labelPassword = new Label();
            linkLabelForgotPW = new LinkLabel();
            buttonLogin = new Button();
            linkLabelRegisterPage = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(283, 142);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(158, 155);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLogo.ForeColor = SystemColors.ControlLightLight;
            labelLogo.Location = new Point(436, 200);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(223, 32);
            labelLogo.TabIndex = 1;
            labelLogo.Text = "Sanctuary of Sound";
            labelLogo.Click += labelLogo_Click;
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeading.ForeColor = SystemColors.ControlLightLight;
            labelHeading.Location = new Point(401, 312);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(103, 40);
            labelHeading.TabIndex = 2;
            labelHeading.Text = "Log In";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = SystemColors.GrayText;
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.ForeColor = SystemColors.Window;
            textBoxEmail.Location = new Point(312, 368);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(316, 29);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.GrayText;
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.ForeColor = SystemColors.Window;
            textBoxPassword.Location = new Point(312, 403);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(316, 29);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.ForeColor = SystemColors.ControlLightLight;
            labelEmail.Location = new Point(233, 376);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.ForeColor = SystemColors.ControlLightLight;
            labelPassword.Location = new Point(233, 411);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password";
            // 
            // linkLabelForgotPW
            // 
            linkLabelForgotPW.AutoSize = true;
            linkLabelForgotPW.LinkColor = Color.White;
            linkLabelForgotPW.Location = new Point(528, 435);
            linkLabelForgotPW.Name = "linkLabelForgotPW";
            linkLabelForgotPW.Size = new Size(100, 15);
            linkLabelForgotPW.TabIndex = 7;
            linkLabelForgotPW.TabStop = true;
            linkLabelForgotPW.Text = "Forgot password?";
            linkLabelForgotPW.LinkClicked += linkLabelForgotPW_LinkClicked;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.GrayText;
            buttonLogin.ForeColor = SystemColors.ControlLightLight;
            buttonLogin.Location = new Point(383, 479);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(139, 44);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // linkLabelRegisterPage
            // 
            linkLabelRegisterPage.AutoSize = true;
            linkLabelRegisterPage.LinkColor = Color.White;
            linkLabelRegisterPage.Location = new Point(345, 540);
            linkLabelRegisterPage.Name = "linkLabelRegisterPage";
            linkLabelRegisterPage.Size = new Size(202, 15);
            linkLabelRegisterPage.TabIndex = 9;
            linkLabelRegisterPage.TabStop = true;
            linkLabelRegisterPage.Text = "Don't have an account? Register here";
            linkLabelRegisterPage.LinkClicked += linkLabelRegisterPage_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(901, 771);
            Controls.Add(linkLabelRegisterPage);
            Controls.Add(buttonLogin);
            Controls.Add(linkLabelForgotPW);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(labelHeading);
            Controls.Add(labelLogo);
            Controls.Add(pictureBoxLogo);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            FormClosing += Login_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label labelLogo;
        private Label labelHeading;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Label labelEmail;
        private Label labelPassword;
        private LinkLabel linkLabelForgotPW;
        private Button buttonLogin;
        private LinkLabel linkLabelRegisterPage;
    }
}