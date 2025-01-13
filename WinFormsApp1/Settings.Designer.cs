namespace WinFormsApp1
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            UpdateEmailBtn = new Button();
            ChangePwdBtn = new Button();
            label1 = new Label();
            pictureBoxLogo = new PictureBox();
            HomeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // UpdateEmailBtn
            // 
            UpdateEmailBtn.BackColor = SystemColors.GrayText;
            UpdateEmailBtn.Cursor = Cursors.Hand;
            UpdateEmailBtn.ForeColor = SystemColors.ControlLightLight;
            UpdateEmailBtn.Location = new Point(176, 293);
            UpdateEmailBtn.Name = "UpdateEmailBtn";
            UpdateEmailBtn.Size = new Size(259, 37);
            UpdateEmailBtn.TabIndex = 0;
            UpdateEmailBtn.Text = "Update Email Address";
            UpdateEmailBtn.UseVisualStyleBackColor = false;
            UpdateEmailBtn.Click += UpdateEmailBtn_Click;
            // 
            // ChangePwdBtn
            // 
            ChangePwdBtn.BackColor = SystemColors.GrayText;
            ChangePwdBtn.Cursor = Cursors.Hand;
            ChangePwdBtn.ForeColor = SystemColors.ControlLightLight;
            ChangePwdBtn.Location = new Point(176, 370);
            ChangePwdBtn.Name = "ChangePwdBtn";
            ChangePwdBtn.Size = new Size(259, 37);
            ChangePwdBtn.TabIndex = 1;
            ChangePwdBtn.Text = "Change Password";
            ChangePwdBtn.UseVisualStyleBackColor = false;
            ChangePwdBtn.Click += ChangePwdBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(190, 201);
            label1.Name = "label1";
            label1.Size = new Size(240, 38);
            label1.TabIndex = 3;
            label1.Text = "Account Settings";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(220, 6);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(174, 179);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 25;
            pictureBoxLogo.TabStop = false;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = SystemColors.GrayText;
            HomeBtn.Cursor = Cursors.Hand;
            HomeBtn.ForeColor = SystemColors.ControlLightLight;
            HomeBtn.Location = new Point(176, 445);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(259, 37);
            HomeBtn.TabIndex = 26;
            HomeBtn.Text = "Back to home";
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += button1_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(611, 614);
            Controls.Add(HomeBtn);
            Controls.Add(pictureBoxLogo);
            Controls.Add(label1);
            Controls.Add(ChangePwdBtn);
            Controls.Add(UpdateEmailBtn);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateEmailBtn;
        private Button ChangePwdBtn;
        private Label label1;
        private PictureBox pictureBoxLogo;
        private Button HomeBtn;
    }
}