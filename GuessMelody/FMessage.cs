using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessMelody
{
    public partial class FMessage : Form
    {
        int TimeAnswer=10;

        public FMessage()
        {
            InitializeComponent();
        }

        private void FMessage_Load(object sender, EventArgs e)
        {
            TimeAnswer = 5;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeAnswer--;
            LblTimeAnswer.Text = TimeAnswer.ToString();
            if (TimeAnswer == 0)
            {
                timer1.Stop();
                SoundPlayer sp = new SoundPlayer("Resources\\Stop.wav");
                sp.Play();
            }
        }

        private void FMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}
