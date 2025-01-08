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
            TrackList = new ListBox();
            UploadMusic = new Button();
            AlbumCover = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            label5 = new Label();
            splitter1 = new Splitter();
            Volume = new TrackBar();
            MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            pictureBox1 = new PictureBox();
            PauseBtn = new Button();
            BackBtn = new Button();
            SkipBtn = new Button();
            PlayBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AlbumCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Volume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MediaPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TrackList
            // 
            TrackList.BackColor = SystemColors.GrayText;
            TrackList.BorderStyle = BorderStyle.FixedSingle;
            TrackList.ForeColor = SystemColors.ControlLightLight;
            TrackList.FormattingEnabled = true;
            TrackList.ItemHeight = 15;
            TrackList.Location = new Point(355, 60);
            TrackList.Name = "TrackList";
            TrackList.Size = new Size(244, 422);
            TrackList.TabIndex = 0;
            TrackList.SelectedIndexChanged += TrackList_SelectedIndexChanged;
            // 
            // UploadMusic
            // 
            UploadMusic.BackColor = SystemColors.GrayText;
            UploadMusic.ForeColor = SystemColors.ControlLightLight;
            UploadMusic.Location = new Point(355, 502);
            UploadMusic.Name = "UploadMusic";
            UploadMusic.Size = new Size(244, 46);
            UploadMusic.TabIndex = 1;
            UploadMusic.Text = "Upload music";
            UploadMusic.UseVisualStyleBackColor = false;
            UploadMusic.Click += UploadMusic_Click;
            // 
            // AlbumCover
            // 
            AlbumCover.Location = new Point(105, 190);
            AlbumCover.Name = "AlbumCover";
            AlbumCover.Size = new Size(149, 144);
            AlbumCover.SizeMode = PictureBoxSizeMode.StretchImage;
            AlbumCover.TabIndex = 2;
            AlbumCover.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(45, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(148, 146);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
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
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.Control;
            progressBar1.ForeColor = SystemColors.GradientInactiveCaption;
            progressBar1.Location = new Point(71, 434);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(199, 12);
            progressBar1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(276, 433);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 15;
            label5.Text = "00:00";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 614);
            splitter1.TabIndex = 16;
            splitter1.TabStop = false;
            // 
            // Volume
            // 
            Volume.Location = new Point(79, 537);
            Volume.Name = "Volume";
            Volume.Size = new Size(226, 45);
            Volume.TabIndex = 17;
            // 
            // MediaPlayer
            // 
            MediaPlayer.Enabled = true;
            MediaPlayer.Location = new Point(88, 74);
            MediaPlayer.Name = "MediaPlayer";
            MediaPlayer.OcxState = (AxHost.State)resources.GetObject("MediaPlayer.OcxState");
            MediaPlayer.Size = new Size(75, 23);
            MediaPlayer.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 524);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // PauseBtn
            // 
            PauseBtn.BackColor = SystemColors.WindowText;
            PauseBtn.BackgroundImage = (Image)resources.GetObject("PauseBtn.BackgroundImage");
            PauseBtn.BackgroundImageLayout = ImageLayout.Stretch;
            PauseBtn.FlatAppearance.BorderSize = 0;
            PauseBtn.FlatStyle = FlatStyle.Flat;
            PauseBtn.Location = new Point(149, 490);
            PauseBtn.Name = "PauseBtn";
            PauseBtn.Size = new Size(16, 21);
            PauseBtn.TabIndex = 24;
            PauseBtn.UseVisualStyleBackColor = false;
            PauseBtn.Click += PauseBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackgroundImage = (Image)resources.GetObject("BackBtn.BackgroundImage");
            BackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Location = new Point(71, 488);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(26, 23);
            BackBtn.TabIndex = 26;
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // SkipBtn
            // 
            SkipBtn.BackgroundImage = (Image)resources.GetObject("SkipBtn.BackgroundImage");
            SkipBtn.BackgroundImageLayout = ImageLayout.Stretch;
            SkipBtn.FlatStyle = FlatStyle.Flat;
            SkipBtn.Location = new Point(279, 490);
            SkipBtn.Name = "SkipBtn";
            SkipBtn.Size = new Size(31, 23);
            SkipBtn.TabIndex = 27;
            SkipBtn.UseVisualStyleBackColor = true;
            SkipBtn.Click += SkipBtn_Click;
            // 
            // PlayBtn
            // 
            PlayBtn.BackgroundImage = (Image)resources.GetObject("PlayBtn.BackgroundImage");
            PlayBtn.BackgroundImageLayout = ImageLayout.Stretch;
            PlayBtn.FlatStyle = FlatStyle.Flat;
            PlayBtn.Location = new Point(220, 490);
            PlayBtn.Name = "PlayBtn";
            PlayBtn.Size = new Size(23, 23);
            PlayBtn.TabIndex = 28;
            PlayBtn.UseVisualStyleBackColor = true;
            PlayBtn.Click += PlayBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(611, 614);
            Controls.Add(PlayBtn);
            Controls.Add(SkipBtn);
            Controls.Add(BackBtn);
            Controls.Add(PauseBtn);
            Controls.Add(pictureBox1);
            Controls.Add(Volume);
            Controls.Add(splitter1);
            Controls.Add(label5);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(AlbumCover);
            Controls.Add(UploadMusic);
            Controls.Add(TrackList);
            Controls.Add(MediaPlayer);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            FormClosing += Home_FormClosing;
            ((System.ComponentModel.ISupportInitialize)AlbumCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Volume).EndInit();
            ((System.ComponentModel.ISupportInitialize)MediaPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox TrackList;
        private Button UploadMusic;
        private PictureBox AlbumCover;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private ProgressBar progressBar1;
        private Label label5;
        private Splitter splitter1;
        private TrackBar Volume;
        private PictureBox PlayButton;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private PictureBox pictureBox1;
        private Button PauseBtn;
        private Button SkipBtn;
        private Button BackBtn;
        private Button PlayBtn;
    }
}
