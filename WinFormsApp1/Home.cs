using System.Diagnostics;
using System.Media;

namespace WinFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            VolumeTrackBar.Value = 50;
        }
        string[] paths, files;

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UploadMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    TrackList.Items.Add(files[x]);
                }
            }
        }

        private void TrackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaPlayer.URL = paths[TrackList.SelectedIndex];
            MediaPlayer.Ctlcontrols.play();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.play();
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.pause();
        }

        private void SkipBtn_Click(object sender, EventArgs e)
        {
            if (TrackList.SelectedIndex < TrackList.Items.Count - 1)
            {
                TrackList.SelectedIndex = TrackList.SelectedIndex + 1;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (TrackList.SelectedIndex > 0)
            {
                TrackList.SelectedIndex = TrackList.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                ProgressBar.Maximum = (int)MediaPlayer.Ctlcontrols.currentItem.duration;
                ProgressBar.Value = (int)MediaPlayer.Ctlcontrols.currentPosition;
            }
            try
            {
                TrackTimer.Text = MediaPlayer.Ctlcontrols.currentPositionString;
            }
            catch
            {

            }
        }

        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            MediaPlayer.settings.volume = VolumeTrackBar.Value;
        }

        private void AccountSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Settings = new Settings();
            Settings.Show();
            //Disabled due to the application exit function at the top of this code
            //this.Close();
        }

        private void ProgressBar_MouseDown(object sender, MouseEventArgs e)
        {
            MediaPlayer.Ctlcontrols.currentPosition = MediaPlayer.currentMedia.duration * e.X / ProgressBar.Width;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
