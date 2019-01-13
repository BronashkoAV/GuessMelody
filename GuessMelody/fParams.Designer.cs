namespace GuessMelody
{
    partial class FParams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FParams));
            this.LbMusic = new System.Windows.Forms.ListBox();
            this.BtnSelectFolder = new System.Windows.Forms.Button();
            this.BtnClearList = new System.Windows.Forms.Button();
            this.CbAllDirectory = new System.Windows.Forms.CheckBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GBSettings = new System.Windows.Forms.GroupBox();
            this.LblContinue = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.CBGameDuration = new System.Windows.Forms.ComboBox();
            this.CBMusicDuration = new System.Windows.Forms.ComboBox();
            this.CBRandomStart = new System.Windows.Forms.CheckBox();
            this.GBSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbMusic
            // 
            this.LbMusic.FormattingEnabled = true;
            this.LbMusic.ItemHeight = 16;
            this.LbMusic.Location = new System.Drawing.Point(13, 13);
            this.LbMusic.Name = "LbMusic";
            this.LbMusic.Size = new System.Drawing.Size(1237, 388);
            this.LbMusic.TabIndex = 0;
            // 
            // BtnSelectFolder
            // 
            this.BtnSelectFolder.Location = new System.Drawing.Point(13, 407);
            this.BtnSelectFolder.Name = "BtnSelectFolder";
            this.BtnSelectFolder.Size = new System.Drawing.Size(186, 43);
            this.BtnSelectFolder.TabIndex = 1;
            this.BtnSelectFolder.Text = "Выбрать папку";
            this.BtnSelectFolder.UseVisualStyleBackColor = true;
            this.BtnSelectFolder.Click += new System.EventHandler(this.BtnSelectFolder_Click);
            // 
            // BtnClearList
            // 
            this.BtnClearList.Location = new System.Drawing.Point(205, 407);
            this.BtnClearList.Name = "BtnClearList";
            this.BtnClearList.Size = new System.Drawing.Size(186, 43);
            this.BtnClearList.TabIndex = 2;
            this.BtnClearList.Text = "Очистить";
            this.BtnClearList.UseVisualStyleBackColor = true;
            this.BtnClearList.Click += new System.EventHandler(this.BtnClearList_Click);
            // 
            // CbAllDirectory
            // 
            this.CbAllDirectory.AutoSize = true;
            this.CbAllDirectory.Location = new System.Drawing.Point(420, 419);
            this.CbAllDirectory.Name = "CbAllDirectory";
            this.CbAllDirectory.Size = new System.Drawing.Size(149, 21);
            this.CbAllDirectory.TabIndex = 3;
            this.CbAllDirectory.Text = "Вложенные папки";
            this.CbAllDirectory.UseVisualStyleBackColor = true;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(872, 618);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(186, 43);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "ОК";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(1064, 618);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(186, 43);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GBSettings
            // 
            this.GBSettings.Controls.Add(this.CBRandomStart);
            this.GBSettings.Controls.Add(this.CBMusicDuration);
            this.GBSettings.Controls.Add(this.CBGameDuration);
            this.GBSettings.Controls.Add(this.LblTime);
            this.GBSettings.Controls.Add(this.LblContinue);
            this.GBSettings.Location = new System.Drawing.Point(13, 457);
            this.GBSettings.Name = "GBSettings";
            this.GBSettings.Size = new System.Drawing.Size(378, 204);
            this.GBSettings.TabIndex = 6;
            this.GBSettings.TabStop = false;
            this.GBSettings.Text = "Настройки игры";
            // 
            // LblContinue
            // 
            this.LblContinue.AutoSize = true;
            this.LblContinue.Location = new System.Drawing.Point(7, 35);
            this.LblContinue.Name = "LblContinue";
            this.LblContinue.Size = new System.Drawing.Size(177, 17);
            this.LblContinue.TabIndex = 0;
            this.LblContinue.Text = "Продолжительность игры";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(7, 81);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(111, 17);
            this.LblTime.TabIndex = 1;
            this.LblTime.Text = "Время на ответ";
            // 
            // CBGameDuration
            // 
            this.CBGameDuration.FormattingEnabled = true;
            this.CBGameDuration.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10",
            "5",
            "1"});
            this.CBGameDuration.Location = new System.Drawing.Point(192, 32);
            this.CBGameDuration.Name = "CBGameDuration";
            this.CBGameDuration.Size = new System.Drawing.Size(121, 24);
            this.CBGameDuration.TabIndex = 2;
            this.CBGameDuration.Text = "60";
            // 
            // CBMusicDuration
            // 
            this.CBMusicDuration.FormattingEnabled = true;
            this.CBMusicDuration.Items.AddRange(new object[] {
            "50",
            "40",
            "30",
            "20",
            "10",
            "5"});
            this.CBMusicDuration.Location = new System.Drawing.Point(192, 78);
            this.CBMusicDuration.Name = "CBMusicDuration";
            this.CBMusicDuration.Size = new System.Drawing.Size(121, 24);
            this.CBMusicDuration.TabIndex = 3;
            this.CBMusicDuration.Text = "20";
            // 
            // CBRandomStart
            // 
            this.CBRandomStart.AutoSize = true;
            this.CBRandomStart.Location = new System.Drawing.Point(10, 132);
            this.CBRandomStart.Name = "CBRandomStart";
            this.CBRandomStart.Size = new System.Drawing.Size(169, 21);
            this.CBRandomStart.TabIndex = 4;
            this.CBRandomStart.Text = "Со случайного места";
            this.CBRandomStart.UseVisualStyleBackColor = true;
            // 
            // FParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.GBSettings);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.CbAllDirectory);
            this.Controls.Add(this.BtnClearList);
            this.Controls.Add(this.BtnSelectFolder);
            this.Controls.Add(this.LbMusic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FParams";
            this.Text = "Настройки";
            this.GBSettings.ResumeLayout(false);
            this.GBSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbMusic;
        private System.Windows.Forms.Button BtnSelectFolder;
        private System.Windows.Forms.Button BtnClearList;
        private System.Windows.Forms.CheckBox CbAllDirectory;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox GBSettings;
        private System.Windows.Forms.CheckBox CBRandomStart;
        private System.Windows.Forms.ComboBox CBMusicDuration;
        private System.Windows.Forms.ComboBox CBGameDuration;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblContinue;
    }
}