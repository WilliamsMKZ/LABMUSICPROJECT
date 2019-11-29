using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace LABMUSIC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        string[] paths, files;
        int Startindex = 0;
        string[] FileName, FilePath;
        Boolean Playnext = false;


        bool playing = false;

        public bool isplaying
        {
            get
            {
                return playing;
            }
            set
            {
                playing = value;
                if (playing)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause(); BtnAction.Image = BtnPlay.Image;
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play(); BtnAction.Image = BtnPause.Image;
                }
            }
        }



        private void Menu_Load(object sender, EventArgs e)
        {
            Startindex = 0;
            Playnext = false;
            StopPlayer();
        }

        public void StopPlayer()
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }


        private void BtnShows_Click(object sender, EventArgs e)
        {
            Shows shows = new Shows();
            shows.Show();
        }

        private void BtnArtistasFavoritos_Click(object sender, EventArgs e)
        {
            ArtistasFavoritos artistasFavoritos = new ArtistasFavoritos();
            artistasFavoritos.Show();
        }

        private void BtnTocandoAgora_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.BringToFront();
        }

        private void BtnFechar3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnProcurarMusicas_Click(object sender, EventArgs e)
        {
            Startindex = 0;
            Playnext = false;
            OpenFileDialog opnFileDlg = new OpenFileDialog();
            opnFileDlg.Multiselect = true;
            opnFileDlg.Filter = "(mp3,wav,mp4,mov,wmv,mpg,avi,3gp,flv)|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;*.mpg| Todos os Formatos |*.*";
            if (opnFileDlg.ShowDialog() == DialogResult.OK)
            {
                FileName = opnFileDlg.SafeFileNames;
                FilePath = opnFileDlg.FileNames;
                for (int i = 0; i <= FileName.Length - 1; i++)
                {
                    listBox1.Items.Add(FileName[i]);
                }
                Startindex = 0;
                playfile(0);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Startindex = listBox1.SelectedIndex;
            playfile(Startindex);
            bunifuCustomLabel3.Text = listBox1.Text;

        }

        private void BtnPlaylist_Click(object sender, EventArgs e)
        {
            listBox1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            bunifuCustomLabel2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                bunifuProgressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {

            if (Startindex == listBox1.Items.Count - 1)
            {
                Startindex = listBox1.Items.Count - 1;
            }
            else if (Startindex < listBox1.Items.Count)
            {
                Startindex = Startindex + 1;
            }
            playfile(Startindex);
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (Startindex > 0)
            {
                Startindex = Startindex - 1;
            }
            playfile(Startindex);
        }

        public EventHandler onActon = null;
        private void BtnAction_Click(object sender, EventArgs e)
        {
            isplaying = !isplaying;
            if (onActon != null)
            {
                onActon.Invoke(this, e);
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                bunifuProgressBar1.MaximumValue = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                bunifuProgressBar1.Value = 0;
            }
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = bunifuSlider1.Value;
            bunifuCustomLabel4.Text = bunifuSlider1.Value.ToString();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            StopPlayer();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void BtnAlbum_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            bunifuImageButton8.BringToFront();
            bunifuImageButton10.BringToFront();
            bunifuImageButton11.BringToFront();
            bunifuImageButton12.BringToFront();
            bunifuImageButton13.BringToFront();
            bunifuImageButton14.BringToFront();
            bunifuImageButton15.BringToFront();
            bunifuImageButton16.BringToFront();
            bunifuCustomLabel5.BringToFront();
            bunifuCustomLabel6.BringToFront();
            bunifuCustomLabel7.BringToFront();
            bunifuCustomLabel8.BringToFront();
            bunifuCustomLabel9.BringToFront();
            bunifuCustomLabel10.BringToFront();
            bunifuCustomLabel11.BringToFront();
            bunifuCustomLabel12.BringToFront();

        }

        private void bunifuCustomLabel19_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {

        }

        private void BtnRadioLabMusic_Click(object sender, EventArgs e)
        {
            RadioLabMusic radioLabMusic = new RadioLabMusic();
            radioLabMusic.Show();
        }

        public void playfile(int playlistindex)
        {
            if (listBox1.Items.Count <= 0)
            {
                return;
            }
            if (playlistindex < 0)
            {
                return;
            }
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.URL = FilePath[playlistindex];
            axWindowsMediaPlayer1.Ctlcontrols.next();
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

    }
}
