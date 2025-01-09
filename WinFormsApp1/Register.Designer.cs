namespace WinFormsApp1
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            labelLogo = new Label();
            labelHeading = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            textBoxFirstName = new TextBox();
            labelCaptcha = new Label();
            labelCaptchaBox = new Label();
            labelPolicy = new Label();
            textBoxPolicy = new TextBox();
            checkBoxPolicy = new CheckBox();
            buttonCreateAcc = new Button();
            linkLabelLoginPage = new LinkLabel();
            textBoxLastName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            textBoxCaptcha = new TextBox();
            pictureBoxLogo = new PictureBox();
            labelEmail = new Label();
            labelPassword = new Label();
            buttonNewCaptcha = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.BackColor = SystemColors.ActiveCaptionText;
            labelLogo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLogo.ForeColor = SystemColors.ControlLightLight;
            labelLogo.Location = new Point(421, 83);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(223, 32);
            labelLogo.TabIndex = 1;
            labelLogo.Text = "Sanctuary of Sound";
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeading.ForeColor = SystemColors.ControlLightLight;
            labelHeading.Location = new Point(309, 223);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(297, 40);
            labelHeading.TabIndex = 2;
            labelHeading.Text = "Create New Account";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.ForeColor = SystemColors.ControlLightLight;
            labelFirstName.Location = new Point(250, 315);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(64, 15);
            labelFirstName.TabIndex = 3;
            labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.ForeColor = SystemColors.ControlLightLight;
            labelLastName.Location = new Point(250, 360);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(63, 15);
            labelLastName.TabIndex = 4;
            labelLastName.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = SystemColors.GrayText;
            textBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstName.ForeColor = SystemColors.Window;
            textBoxFirstName.Location = new Point(320, 309);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(297, 27);
            textBoxFirstName.TabIndex = 7;
            // 
            // labelCaptcha
            // 
            labelCaptcha.AutoSize = true;
            labelCaptcha.ForeColor = SystemColors.ControlLightLight;
            labelCaptcha.Location = new Point(250, 508);
            labelCaptcha.Name = "labelCaptcha";
            labelCaptcha.Size = new Size(60, 15);
            labelCaptcha.TabIndex = 12;
            labelCaptcha.Text = "CAPTCHA";
            // 
            // labelCaptchaBox
            // 
            labelCaptchaBox.AutoSize = true;
            labelCaptchaBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCaptchaBox.ForeColor = SystemColors.ControlLightLight;
            labelCaptchaBox.Location = new Point(369, 502);
            labelCaptchaBox.Name = "labelCaptchaBox";
            labelCaptchaBox.Size = new Size(80, 25);
            labelCaptchaBox.TabIndex = 14;
            labelCaptchaBox.Text = "captcha";
            // 
            // labelPolicy
            // 
            labelPolicy.AutoSize = true;
            labelPolicy.ForeColor = SystemColors.ControlLightLight;
            labelPolicy.Location = new Point(250, 550);
            labelPolicy.Name = "labelPolicy";
            labelPolicy.Size = new Size(80, 15);
            labelPolicy.TabIndex = 15;
            labelPolicy.Text = "Privacy Policy";
            // 
            // textBoxPolicy
            // 
            textBoxPolicy.BackColor = SystemColors.Desktop;
            textBoxPolicy.BorderStyle = BorderStyle.None;
            textBoxPolicy.ForeColor = SystemColors.Window;
            textBoxPolicy.Location = new Point(342, 550);
            textBoxPolicy.Multiline = true;
            textBoxPolicy.Name = "textBoxPolicy";
            textBoxPolicy.Size = new Size(275, 123);
            textBoxPolicy.TabIndex = 16;
            textBoxPolicy.Text = "Our privacy policy is based upon the values set by the Standards Association's Model Code for the Protection of Personal Information and Personal Information Protection and Documents Act.";
            // 
            // checkBoxPolicy
            // 
            checkBoxPolicy.AutoSize = true;
            checkBoxPolicy.ForeColor = SystemColors.ControlLightLight;
            checkBoxPolicy.Location = new Point(250, 633);
            checkBoxPolicy.Name = "checkBoxPolicy";
            checkBoxPolicy.Size = new Size(171, 19);
            checkBoxPolicy.TabIndex = 17;
            checkBoxPolicy.Text = "I agree to the privacy policy";
            checkBoxPolicy.UseVisualStyleBackColor = true;
            // 
            // buttonCreateAcc
            // 
            buttonCreateAcc.BackColor = SystemColors.GrayText;
            buttonCreateAcc.ForeColor = SystemColors.ControlLightLight;
            buttonCreateAcc.Location = new Point(369, 672);
            buttonCreateAcc.Name = "buttonCreateAcc";
            buttonCreateAcc.Size = new Size(148, 61);
            buttonCreateAcc.TabIndex = 18;
            buttonCreateAcc.Text = "Create Account";
            buttonCreateAcc.UseVisualStyleBackColor = false;
            buttonCreateAcc.Click += buttonCreateAcc_Click;
            // 
            // linkLabelLoginPage
            // 
            linkLabelLoginPage.AutoSize = true;
            linkLabelLoginPage.LinkColor = Color.White;
            linkLabelLoginPage.Location = new Point(360, 743);
            linkLabelLoginPage.Name = "linkLabelLoginPage";
            linkLabelLoginPage.Size = new Size(166, 15);
            linkLabelLoginPage.TabIndex = 19;
            linkLabelLoginPage.TabStop = true;
            linkLabelLoginPage.Text = "Already registered? Login here";
            linkLabelLoginPage.LinkClicked += linkLabelLoginPage_LinkClicked;
            // 
            // textBoxLastName
            // 
            textBoxLastName.BackColor = SystemColors.GrayText;
            textBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            textBoxLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLastName.ForeColor = SystemColors.Window;
            textBoxLastName.Location = new Point(320, 354);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(297, 27);
            textBoxLastName.TabIndex = 20;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = SystemColors.GrayText;
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.ForeColor = SystemColors.Window;
            textBoxEmail.Location = new Point(320, 400);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(297, 27);
            textBoxEmail.TabIndex = 21;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.GrayText;
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.ForeColor = SystemColors.Window;
            textBoxPassword.Location = new Point(320, 445);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(297, 27);
            textBoxPassword.TabIndex = 22;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxCaptcha
            // 
            textBoxCaptcha.BackColor = SystemColors.GrayText;
            textBoxCaptcha.BorderStyle = BorderStyle.FixedSingle;
            textBoxCaptcha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCaptcha.ForeColor = SystemColors.Window;
            textBoxCaptcha.Location = new Point(478, 502);
            textBoxCaptcha.Name = "textBoxCaptcha";
            textBoxCaptcha.Size = new Size(139, 27);
            textBoxCaptcha.TabIndex = 23;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(255, 13);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(174, 179);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 24;
            pictureBoxLogo.TabStop = false;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.ForeColor = SystemColors.ControlLightLight;
            labelEmail.Location = new Point(250, 406);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 25;
            labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.ForeColor = SystemColors.ControlLightLight;
            labelPassword.Location = new Point(250, 451);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 26;
            labelPassword.Text = "Password";
            // 
            // buttonNewCaptcha
            // 
            buttonNewCaptcha.Location = new Point(320, 505);
            buttonNewCaptcha.Name = "buttonNewCaptcha";
            buttonNewCaptcha.Size = new Size(43, 21);
            buttonNewCaptcha.TabIndex = 27;
            buttonNewCaptcha.Text = "Reset";
            buttonNewCaptcha.UseVisualStyleBackColor = true;
            buttonNewCaptcha.Click += buttonNewCaptcha_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(901, 771);
            Controls.Add(buttonNewCaptcha);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(pictureBoxLogo);
            Controls.Add(textBoxCaptcha);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxLastName);
            Controls.Add(linkLabelLoginPage);
            Controls.Add(buttonCreateAcc);
            Controls.Add(checkBoxPolicy);
            Controls.Add(textBoxPolicy);
            Controls.Add(labelPolicy);
            Controls.Add(labelCaptchaBox);
            Controls.Add(labelCaptcha);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(labelHeading);
            Controls.Add(labelLogo);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelLogo;
        private Label labelHeading;
        private Label labelFirstName;
        private Label labelLastName;
        private TextBox textBoxFirstName;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Label labelCaptcha;
        private TextBox textBox5;
        private Label labelCaptchaBox;
        private Label labelPolicy;
        private TextBox textBoxPolicy;
        private CheckBox checkBoxPolicy;
        private Button buttonCreateAcc;
        private LinkLabel linkLabelLoginPage;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private TextBox textBoxCaptcha;
        private PictureBox pictureBoxLogo;
        private Label labelEmail;
        private Label labelPassword;
        private Button buttonNewCaptcha;
    }
}