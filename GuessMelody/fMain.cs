using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Убирать FMain при открытии другого окна

namespace GuessMelody
{
    public partial class FMain : Form
    {
        FParams fp = new FParams();
        FGame fg = new FGame();

        public FMain()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            //this.Hide();
            fp.ShowDialog();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            //this.Hide();
            fg.ShowDialog();
        }
    }
}
