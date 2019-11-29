using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABMUSIC
{
    public partial class RadioLabMusic : Form
    {
        public RadioLabMusic()
        {
            InitializeComponent();
        }



        private void RadioLabMusic_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Radio Planet 60 - Anos 60s");
            listBox1.Items.Add("Radio Hunter - Anos 80 - Qualidade Alta");
            listBox1.Items.Add("Radio Hunter - Anos 80 - Qualidade Média");
            listBox1.Items.Add("Radio Hunter - Anos 80 - Qualidade Baixa");
            listBox1.Items.Add("Radio Planet 80s - Classicos 80");
            listBox1.Items.Add("Radio Hunter - Pop - Qualidade Alta");
            listBox1.Items.Add("Radio Hunter - Pop - Qualidade Média");
            listBox1.Items.Add("Radio Hunter - Pop - Qualidade Baixa");
            listBox1.Items.Add("Radio Hunter - Rock - Qualidade Alta");
            listBox1.Items.Add("Radio Hunter - Rock - Qualidade Média");
            listBox1.Items.Add("Radio Hunter - Rock - Qualidade Baixa");
            listBox1.Items.Add("Radio Hunter - Sertanejo - Qualidade Alta");
            listBox1.Items.Add("Radio Hunter - Sertanejo - Qualidade Média");
            listBox1.Items.Add("Radio Hunter - Sertanejo - Qualidade Baixa");
            listBox1.Items.Add("Radio Power Hitz 108");
            listBox1.Items.Add("Radio Hitlist");
            listBox1.Items.Add("Radio Total Country");
            listBox1.Items.Add("Radio Office Mix");
        }

        private void BtnOuvirRadio_Click(object sender, EventArgs e)
        {
        }  

        private void BtnVoltar3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }

        private void BtnOuvirRadio_Click_1(object sender, EventArgs e)
        {
            string URL = string.Empty;
            switch (listBox1.SelectedIndex)
            {
                case 0: // Planet 60s
                    URL = "http://listen.openstream.co/3162/audio";
                    break;
                case 1: // Radio Hunter 80s - Qualidade Alta
                    URL = "http://live.hunter.fm/80s";
                    break;
                case 2: // Radio Hunter 80s - Qualidade Média
                    URL = "http://live.hunter.fm/m80s";
                    break;
                case 3: // Radio Hunter 80s - Qualidade Baixa
                    URL = "http://live.hunter.fm/80s32";
                    break;
                case 4: // Planet 80s
                    URL = "http://listen.shoutcast.com/80splanet";
                    break;
                case 5: // Radio Hunter Pop - Qualidade Alta
                    URL = "http://live.hunter.fm/live";
                    break;
                case 6: // Radio Hunter Pop - Qualidade Média
                    URL = "http://live.hunter.fm/mobile";
                    break;
                case 7: // Radio Hunter Pop - Qualidade Baixa
                    URL = "http://live.hunter.fm/hitz32";
                    break;
                case 8: // Radio Hunter Rock - Qualidade Alta
                    URL = "http://live.hunter.fm/rock";
                    break;
                case 9: // Radio Hunter Rock - Qualidade Média
                    URL = "http://live.hunter.fm/mrock";
                    break;
                case 10: // Radio Hunter Rock - Qualidade Baixa
                    URL = "http://live.hunter.fm/rock32";
                    break;
                case 11: // Radio Hunter Sertanejo - Qualidade Alta
                    URL = "http://live.hunter.fm/country";
                    break;
                case 12: // Radio Hunter Sertanejo - Qualidade Média
                    URL = "http://live.hunter.fm/mcountry";
                    break;
                case 13: // Radio Hunter Sertanejo - Qualidade Baixa
                    URL = "http://live.hunter.fm/country32";
                    break;
                case 14: // Radio 108 Jamz 
                    URL = "http://powerhitz.com/wm/hot108jamz.asx";
                    break;
                case 15: // Radio Hitlist
                    URL = "http://powerhitz.com/wm/hitlist.asx";
                    break;
                case 16: // Radio Total Country
                    URL = "http://powerhitz.com/wm/totalcountry.asx";
                    break;
                case 17: // Radio Office Mix
                    URL = "http://powerhitz.com/wm/officemix.asx";
                    break;
                default:
                    MessageBox.Show("Selecione uma Rádio");
                    break;
            }
            if (!URL.Equals("")) axWindowsMediaPlayer1.URL = URL;
        }
    }
    
}
