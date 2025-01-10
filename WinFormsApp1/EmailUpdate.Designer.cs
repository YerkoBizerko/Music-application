namespace WinFormsApp1
{
    partial class EmailUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailUpdate));
            OldEmailTextbox = new TextBox();
            NewEmailTextBox2 = new TextBox();
            UpdateEmailLabel = new Label();
            EmailConfirmationCheckbox = new CheckBox();
            UpdateEmailConfirmBtn = new Button();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // OldEmailTextbox
            // 
            OldEmailTextbox.BackColor = SystemColors.ControlLightLight;
            OldEmailTextbox.BorderStyle = BorderStyle.FixedSingle;
            OldEmailTextbox.ForeColor = SystemColors.WindowText;
            OldEmailTextbox.Location = new Point(201, 293);
            OldEmailTextbox.Name = "OldEmailTextbox";
            OldEmailTextbox.PlaceholderText = "Enter previous email address";
            OldEmailTextbox.Size = new Size(223, 23);
            OldEmailTextbox.TabIndex = 0;
            OldEmailTextbox.TabStop = false;
            // 
            // NewEmailTextBox2
            // 
            NewEmailTextBox2.BackColor = SystemColors.ControlLightLight;
            NewEmailTextBox2.BorderStyle = BorderStyle.FixedSingle;
            NewEmailTextBox2.ForeColor = SystemColors.WindowText;
            NewEmailTextBox2.Location = new Point(201, 340);
            NewEmailTextBox2.Name = "NewEmailTextBox2";
            NewEmailTextBox2.PlaceholderText = "Enter new email address";
            NewEmailTextBox2.Size = new Size(223, 23);
            NewEmailTextBox2.TabIndex = 1;
            // 
            // UpdateEmailLabel
            // 
            UpdateEmailLabel.AutoSize = true;
            UpdateEmailLabel.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateEmailLabel.ForeColor = SystemColors.Window;
            UpdateEmailLabel.Location = new Point(212, 209);
            UpdateEmailLabel.Name = "UpdateEmailLabel";
            UpdateEmailLabel.Size = new Size(192, 38);
            UpdateEmailLabel.TabIndex = 4;
            UpdateEmailLabel.Text = "Update Email";
            // 
            // EmailConfirmationCheckbox
            // 
            EmailConfirmationCheckbox.AutoSize = true;
            EmailConfirmationCheckbox.ForeColor = SystemColors.ControlLightLight;
            EmailConfirmationCheckbox.Location = new Point(195, 393);
            EmailConfirmationCheckbox.Name = "EmailConfirmationCheckbox";
            EmailConfirmationCheckbox.Size = new Size(235, 19);
            EmailConfirmationCheckbox.TabIndex = 5;
            EmailConfirmationCheckbox.Text = "I would like to update my email address";
            EmailConfirmationCheckbox.UseVisualStyleBackColor = true;
            // 
            // UpdateEmailConfirmBtn
            // 
            UpdateEmailConfirmBtn.BackColor = SystemColors.GrayText;
            UpdateEmailConfirmBtn.Cursor = Cursors.Hand;
            UpdateEmailConfirmBtn.ForeColor = SystemColors.ControlLightLight;
            UpdateEmailConfirmBtn.Location = new Point(239, 452);
            UpdateEmailConfirmBtn.Name = "UpdateEmailConfirmBtn";
            UpdateEmailConfirmBtn.Size = new Size(139, 44);
            UpdateEmailConfirmBtn.TabIndex = 6;
            UpdateEmailConfirmBtn.Text = "Confirm";
            UpdateEmailConfirmBtn.UseVisualStyleBackColor = false;
            UpdateEmailConfirmBtn.Click += UpdateEmailConfirmBtn_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(232, 59);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(146, 147);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 26;
            pictureBoxLogo.TabStop = false;
            // 
            // EmailUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(611, 614);
            Controls.Add(pictureBoxLogo);
            Controls.Add(UpdateEmailConfirmBtn);
            Controls.Add(EmailConfirmationCheckbox);
            Controls.Add(UpdateEmailLabel);
            Controls.Add(NewEmailTextBox2);
            Controls.Add(OldEmailTextbox);
            Name = "EmailUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Email";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OldEmailTextbox;
        private TextBox NewEmailTextBox2;
        private Label UpdateEmailLabel;
        private CheckBox EmailConfirmationCheckbox;
        private Button UpdateEmailConfirmBtn;
        private PictureBox pictureBoxLogo;
    }
}