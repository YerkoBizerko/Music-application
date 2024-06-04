namespace WinFormsApp1
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            listBox1 = new ListBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label5 = new Label();
            splitter1 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.GrayText;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.ForeColor = SystemColors.ControlLightLight;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(355, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(244, 422);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(355, 502);
            button1.Name = "button1";
            button1.Size = new Size(244, 46);
            button1.TabIndex = 1;
            button1.Text = "Open Folder";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(105, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 144);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(55, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 99);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(188, 75);
            label1.Name = "label1";
            label1.Size = new Size(122, 21);
            label1.TabIndex = 4;
            label1.Text = "Sweet As Sound";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GrayText;
            button3.Location = new Point(284, 366);
            button3.Name = "button3";
            button3.Size = new Size(26, 23);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(145, 353);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 7;
            label2.Text = "Track Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(146, 372);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 8;
            label3.Text = "Artist Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(143, 388);
            label4.Name = "label4";
            label4.Size = new Size(84, 17);
            label4.TabIndex = 9;
            label4.Text = "Album Name";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GrayText;
            button2.Location = new Point(55, 366);
            button2.Name = "button2";
            button2.Size = new Size(26, 23);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.Control;
            progressBar1.ForeColor = SystemColors.GradientInactiveCaption;
            progressBar1.Location = new Point(55, 434);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(199, 12);
            progressBar1.TabIndex = 11;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GrayText;
            button4.Location = new Point(55, 490);
            button4.Name = "button4";
            button4.Size = new Size(26, 23);
            button4.TabIndex = 12;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GrayText;
            button5.Location = new Point(167, 490);
            button5.Name = "button5";
            button5.Size = new Size(26, 23);
            button5.TabIndex = 13;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.GrayText;
            button6.Location = new Point(284, 490);
            button6.Name = "button6";
            button6.Size = new Size(26, 23);
            button6.TabIndex = 14;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(260, 431);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 15;
            label5.Text = "00:00 / 00:00";
            label5.Click += label5_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 614);
            splitter1.TabIndex = 16;
            splitter1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(611, 614);
            Controls.Add(splitter1);
            Controls.Add(label5);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Home";
            Text = "Home";
            FormClosing += Home_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private ProgressBar progressBar1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label5;
        private Splitter splitter1;
    }
}
