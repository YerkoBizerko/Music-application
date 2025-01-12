namespace WinFormsApp1
{
    partial class PwUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PwUpdate));
            pictureBoxLogo = new PictureBox();
            UpdatePwConfirmBtn = new Button();
            PwConfirmationCheckbox = new CheckBox();
            UpdatePwLabel = new Label();
            NewPwTextBox2 = new TextBox();
            EmailTextbox = new TextBox();
            OldPwTextBox = new TextBox();
            CancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(234, 60);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(146, 147);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 32;
            pictureBoxLogo.TabStop = false;
            // 
            // UpdatePwConfirmBtn
            // 
            UpdatePwConfirmBtn.BackColor = SystemColors.GrayText;
            UpdatePwConfirmBtn.Cursor = Cursors.Hand;
            UpdatePwConfirmBtn.ForeColor = SystemColors.ControlLightLight;
            UpdatePwConfirmBtn.Location = new Point(311, 454);
            UpdatePwConfirmBtn.Name = "UpdatePwConfirmBtn";
            UpdatePwConfirmBtn.Size = new Size(139, 44);
            UpdatePwConfirmBtn.TabIndex = 31;
            UpdatePwConfirmBtn.Text = "Confirm";
            UpdatePwConfirmBtn.UseVisualStyleBackColor = false;
            UpdatePwConfirmBtn.Click += UpdatePwConfirmBtn_Click;
            // 
            // PwConfirmationCheckbox
            // 
            PwConfirmationCheckbox.AutoSize = true;
            PwConfirmationCheckbox.ForeColor = SystemColors.ControlLightLight;
            PwConfirmationCheckbox.Location = new Point(205, 394);
            PwConfirmationCheckbox.Name = "PwConfirmationCheckbox";
            PwConfirmationCheckbox.Size = new Size(215, 19);
            PwConfirmationCheckbox.TabIndex = 30;
            PwConfirmationCheckbox.Text = "I would like to change my password";
            PwConfirmationCheckbox.UseVisualStyleBackColor = true;
            // 
            // UpdatePwLabel
            // 
            UpdatePwLabel.AutoSize = true;
            UpdatePwLabel.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdatePwLabel.ForeColor = SystemColors.Window;
            UpdatePwLabel.Location = new Point(192, 210);
            UpdatePwLabel.Name = "UpdatePwLabel";
            UpdatePwLabel.Size = new Size(245, 38);
            UpdatePwLabel.TabIndex = 29;
            UpdatePwLabel.Text = "Change Password";
            // 
            // NewPwTextBox2
            // 
            NewPwTextBox2.BackColor = SystemColors.ControlLightLight;
            NewPwTextBox2.BorderStyle = BorderStyle.FixedSingle;
            NewPwTextBox2.ForeColor = SystemColors.WindowText;
            NewPwTextBox2.Location = new Point(202, 350);
            NewPwTextBox2.Name = "NewPwTextBox2";
            NewPwTextBox2.PlaceholderText = "Enter new password";
            NewPwTextBox2.Size = new Size(223, 23);
            NewPwTextBox2.TabIndex = 29;
            // 
            // EmailTextbox
            // 
            EmailTextbox.BackColor = SystemColors.ControlLightLight;
            EmailTextbox.BorderStyle = BorderStyle.FixedSingle;
            EmailTextbox.ForeColor = SystemColors.WindowText;
            EmailTextbox.Location = new Point(202, 277);
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.PlaceholderText = "Enter email address";
            EmailTextbox.Size = new Size(223, 23);
            EmailTextbox.TabIndex = 27;
            // 
            // OldPwTextBox
            // 
            OldPwTextBox.BackColor = SystemColors.ControlLightLight;
            OldPwTextBox.BorderStyle = BorderStyle.FixedSingle;
            OldPwTextBox.ForeColor = SystemColors.WindowText;
            OldPwTextBox.Location = new Point(202, 313);
            OldPwTextBox.Name = "OldPwTextBox";
            OldPwTextBox.PlaceholderText = "Enter current password";
            OldPwTextBox.Size = new Size(223, 23);
            OldPwTextBox.TabIndex = 28;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = SystemColors.GrayText;
            CancelBtn.Cursor = Cursors.Hand;
            CancelBtn.ForeColor = SystemColors.ControlLightLight;
            CancelBtn.Location = new Point(166, 454);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(139, 44);
            CancelBtn.TabIndex = 33;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // PwUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(611, 614);
            Controls.Add(CancelBtn);
            Controls.Add(OldPwTextBox);
            Controls.Add(pictureBoxLogo);
            Controls.Add(UpdatePwConfirmBtn);
            Controls.Add(PwConfirmationCheckbox);
            Controls.Add(UpdatePwLabel);
            Controls.Add(NewPwTextBox2);
            Controls.Add(EmailTextbox);
            Name = "PwUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Button UpdatePwConfirmBtn;
        private CheckBox PwConfirmationCheckbox;
        private Label UpdatePwLabel;
        private TextBox NewPwTextBox2;
        private TextBox EmailTextbox;
        private TextBox OldPwTextBox;
        private Button CancelBtn;
    }
}