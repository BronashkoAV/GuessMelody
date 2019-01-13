namespace GuessMelody
{
    partial class FGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.BtnNext = new System.Windows.Forms.Button();
            this.LblPlayerName1 = new System.Windows.Forms.Label();
            this.LblPlayerName2 = new System.Windows.Forms.Label();
            this.LblPlayerScore1 = new System.Windows.Forms.Label();
            this.LblPlayerScore2 = new System.Windows.Forms.Label();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(21, 596);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(237, 48);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            // 
            // BtnNext
            // 
            this.BtnNext.Image = global::GuessMelody.Properties.Resources._1486348813_music_forward_front_next_arrow_blue_80474;
            this.BtnNext.Location = new System.Drawing.Point(576, 296);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(128, 128);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // LblPlayerName1
            // 
            this.LblPlayerName1.AutoSize = true;
            this.LblPlayerName1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPlayerName1.Location = new System.Drawing.Point(20, 20);
            this.LblPlayerName1.Name = "LblPlayerName1";
            this.LblPlayerName1.Size = new System.Drawing.Size(147, 43);
            this.LblPlayerName1.TabIndex = 2;
            this.LblPlayerName1.Text = "Player1";
            // 
            // LblPlayerName2
            // 
            this.LblPlayerName2.AutoSize = true;
            this.LblPlayerName2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPlayerName2.Location = new System.Drawing.Point(1093, 20);
            this.LblPlayerName2.Name = "LblPlayerName2";
            this.LblPlayerName2.Size = new System.Drawing.Size(147, 43);
            this.LblPlayerName2.TabIndex = 3;
            this.LblPlayerName2.Text = "Player2";
            // 
            // LblPlayerScore1
            // 
            this.LblPlayerScore1.AutoSize = true;
            this.LblPlayerScore1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPlayerScore1.Location = new System.Drawing.Point(77, 100);
            this.LblPlayerScore1.Name = "LblPlayerScore1";
            this.LblPlayerScore1.Size = new System.Drawing.Size(32, 35);
            this.LblPlayerScore1.TabIndex = 4;
            this.LblPlayerScore1.Text = "0";
            // 
            // LblPlayerScore2
            // 
            this.LblPlayerScore2.AutoSize = true;
            this.LblPlayerScore2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPlayerScore2.Location = new System.Drawing.Point(1153, 100);
            this.LblPlayerScore2.Name = "LblPlayerScore2";
            this.LblPlayerScore2.Size = new System.Drawing.Size(32, 35);
            this.LblPlayerScore2.TabIndex = 5;
            this.LblPlayerScore2.Text = "0";
            // 
            // BtnPause
            // 
            this.BtnPause.Image = global::GuessMelody.Properties.Resources._1486348820_music_pause_stop_control_play_blue_80477;
            this.BtnPause.Location = new System.Drawing.Point(832, 296);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(128, 128);
            this.BtnPause.TabIndex = 6;
            this.BtnPause.UseVisualStyleBackColor = true;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Image = global::GuessMelody.Properties.Resources._1486348822_music_play_pause_control_go_arrow_blue_80476__1_1;
            this.BtnPlay.Location = new System.Drawing.Point(320, 296);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(128, 128);
            this.BtnPlay.TabIndex = 7;
            this.BtnPlay.UseVisualStyleBackColor = true;
            // 
            // FGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources.videoblocks_4k_club_music_particles_field_dance_motion_background_orange_and_red_bnwlpmrjg_thumbnail_full01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.LblPlayerScore2);
            this.Controls.Add(this.LblPlayerScore1);
            this.Controls.Add(this.LblPlayerName2);
            this.Controls.Add(this.LblPlayerName1);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.WMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FGame";
            this.Text = "FGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FGame_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label LblPlayerName1;
        private System.Windows.Forms.Label LblPlayerName2;
        private System.Windows.Forms.Label LblPlayerScore1;
        private System.Windows.Forms.Label LblPlayerScore2;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnPlay;
    }
}