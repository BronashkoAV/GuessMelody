using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessMelody
{
    public partial class FParams : Form
    {
        public FParams()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Quiz.WriteParam();
            this.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = Directory.GetFiles(fbd.SelectedPath, "*.mp3", CbAllDirectory.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                LbMusic.Items.Clear();
                LbMusic.Items.AddRange(music_list);
                Quiz.ListMusic.Clear();
                Quiz.ListMusic.AddRange(music_list);
            }
        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            LbMusic.Items.Clear();
        }
    }
}
