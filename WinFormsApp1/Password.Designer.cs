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
            labelPassword = new Label();
            labelPWtext = new Label();
            linkLabelLoginPage = new LinkLabel();
            textBoxPWreset = new TextBox();
            buttonPWreset = new Button();
            SuspendLayout();
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = SystemColors.ControlLightLight;
            labelPassword.Location = new Point(86, 73);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(261, 40);
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Forgot password?";
            // 
            // labelPWtext
            // 
            labelPWtext.AutoSize = true;
            labelPWtext.ForeColor = SystemColors.ControlLightLight;
            labelPWtext.Location = new Point(91, 178);
            labelPWtext.Name = "labelPWtext";
            labelPWtext.Size = new Size(251, 15);
            labelPWtext.TabIndex = 1;
            labelPWtext.Text = "Please enter your email to reset your password";
            labelPWtext.Click += label2_Click;
            // 
            // linkLabelLoginPage
            // 
            linkLabelLoginPage.AutoSize = true;
            linkLabelLoginPage.LinkColor = Color.White;
            linkLabelLoginPage.Location = new Point(180, 409);
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
            textBoxPWreset.Location = new Point(97, 206);
            textBoxPWreset.Name = "textBoxPWreset";
            textBoxPWreset.Size = new Size(239, 29);
            textBoxPWreset.TabIndex = 3;
            textBoxPWreset.TextChanged += textBoxPWreset_TextChanged;
            // 
            // buttonPWreset
            // 
            buttonPWreset.BackColor = SystemColors.GrayText;
            buttonPWreset.ForeColor = SystemColors.ControlLightLight;
            buttonPWreset.Location = new Point(144, 270);
            buttonPWreset.Name = "buttonPWreset";
            buttonPWreset.Size = new Size(152, 47);
            buttonPWreset.TabIndex = 4;
            buttonPWreset.Text = "Send Reset Link";
            buttonPWreset.UseVisualStyleBackColor = false;
            buttonPWreset.Click += buttonPWreset_Click;
            // 
            // Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(410, 450);
            Controls.Add(buttonPWreset);
            Controls.Add(textBoxPWreset);
            Controls.Add(linkLabelLoginPage);
            Controls.Add(labelPWtext);
            Controls.Add(labelPassword);
            Name = "Password";
            Text = "Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPassword;
        private Label labelPWtext;
        private LinkLabel linkLabelLoginPage;
        private TextBox textBoxPWreset;
        private Button buttonPWreset;
    }
}