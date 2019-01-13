using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class FGame : Form
    {
        Random rnd = new Random();
        int musicDuration=Quiz.MusicDuration;

        public FGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            if (Quiz.ListMusic.Count == 0) endGame();
            else
            {
                musicDuration = Quiz.MusicDuration;
                int n = rnd.Next(0, Quiz.ListMusic.Count);
                WMP.URL = Quiz.ListMusic[n];
                Quiz.ListMusic.RemoveAt(n);
                LblMelodyCount.Text = Quiz.ListMusic.Count.ToString();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void FGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void FGame_Load(object sender, EventArgs e)
        {
            LblMelodyCount.Text = Quiz.ListMusic.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Quiz.GameDuration;
            LblMusicDuration.Text = musicDuration.ToString();

        }
        void endGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            LblMusicDuration.Text = musicDuration.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                endGame();
                return;
            }
            if (musicDuration == 0) MakeMusic();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            GamePause();
        }
        void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            GamePlay();
        }
        void GamePlay()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        private void FGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                GamePause();
                if (MessageBox.Show("Правильный ответ?", "Player1", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LblPlayerScore1.Text = Convert.ToString(Convert.ToInt32(LblPlayerScore1.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }

            if (e.KeyData == Keys.Enter)
            {
                GamePause();
                if (MessageBox.Show("Правильный ответ?", "Player2", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LblPlayerScore2.Text = Convert.ToString(Convert.ToInt32(LblPlayerScore2.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
        }
    }
}
