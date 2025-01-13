namespace WinFormsApp1
{
    partial class DeleteAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAcc));
            CancelBtn = new Button();
            PwTextBox = new TextBox();
            pictureBoxLogo = new PictureBox();
            DeactivateConfirmBtn = new Button();
            DeactivateCheckbox = new CheckBox();
            DeactivateLabel = new Label();
            EmailTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = SystemColors.GrayText;
            CancelBtn.Cursor = Cursors.Hand;
            CancelBtn.ForeColor = SystemColors.ControlLightLight;
            CancelBtn.Location = new Point(165, 454);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(139, 44);
            CancelBtn.TabIndex = 33;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // PwTextBox
            // 
            PwTextBox.BackColor = SystemColors.ControlLightLight;
            PwTextBox.BorderStyle = BorderStyle.FixedSingle;
            PwTextBox.ForeColor = SystemColors.WindowText;
            PwTextBox.Location = new Point(201, 319);
            PwTextBox.Name = "PwTextBox";
            PwTextBox.PlaceholderText = "Enter password";
            PwTextBox.Size = new Size(223, 23);
            PwTextBox.TabIndex = 35;
            PwTextBox.UseSystemPasswordChar = true;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(233, 60);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(146, 147);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 40;
            pictureBoxLogo.TabStop = false;
            // 
            // DeactivateConfirmBtn
            // 
            DeactivateConfirmBtn.BackColor = SystemColors.GrayText;
            DeactivateConfirmBtn.Cursor = Cursors.Hand;
            DeactivateConfirmBtn.ForeColor = SystemColors.ControlLightLight;
            DeactivateConfirmBtn.Location = new Point(310, 454);
            DeactivateConfirmBtn.Name = "DeactivateConfirmBtn";
            DeactivateConfirmBtn.Size = new Size(139, 44);
            DeactivateConfirmBtn.TabIndex = 39;
            DeactivateConfirmBtn.Text = "Confirm";
            DeactivateConfirmBtn.UseVisualStyleBackColor = false;
            DeactivateConfirmBtn.Click += UpdatePwConfirmBtn_Click;
            // 
            // DeactivateCheckbox
            // 
            DeactivateCheckbox.AutoSize = true;
            DeactivateCheckbox.ForeColor = SystemColors.ControlLightLight;
            DeactivateCheckbox.Location = new Point(124, 389);
            DeactivateCheckbox.Name = "DeactivateCheckbox";
            DeactivateCheckbox.Size = new Size(388, 19);
            DeactivateCheckbox.TabIndex = 38;
            DeactivateCheckbox.Text = "I would like to deactivate my account, i understand this is irreversible";
            DeactivateCheckbox.UseVisualStyleBackColor = true;
            // 
            // DeactivateLabel
            // 
            DeactivateLabel.AutoSize = true;
            DeactivateLabel.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeactivateLabel.ForeColor = SystemColors.Window;
            DeactivateLabel.Location = new Point(176, 210);
            DeactivateLabel.Name = "DeactivateLabel";
            DeactivateLabel.Size = new Size(272, 38);
            DeactivateLabel.TabIndex = 36;
            DeactivateLabel.Text = "Deactivate Account";
            // 
            // EmailTextbox
            // 
            EmailTextbox.BackColor = SystemColors.ControlLightLight;
            EmailTextbox.BorderStyle = BorderStyle.FixedSingle;
            EmailTextbox.ForeColor = SystemColors.WindowText;
            EmailTextbox.Location = new Point(201, 280);
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.PlaceholderText = "Enter email address";
            EmailTextbox.Size = new Size(223, 23);
            EmailTextbox.TabIndex = 34;
            // 
            // DeleteAcc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(611, 614);
            Controls.Add(CancelBtn);
            Controls.Add(PwTextBox);
            Controls.Add(pictureBoxLogo);
            Controls.Add(DeactivateConfirmBtn);
            Controls.Add(DeactivateCheckbox);
            Controls.Add(DeactivateLabel);
            Controls.Add(EmailTextbox);
            Name = "DeleteAcc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deactivate Account";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelBtn;
        private TextBox PwTextBox;
        private PictureBox pictureBoxLogo;
        private Button DeactivateConfirmBtn;
        private CheckBox DeactivateCheckbox;
        private Label DeactivateLabel;
        private TextBox EmailTextbox;
    }
}