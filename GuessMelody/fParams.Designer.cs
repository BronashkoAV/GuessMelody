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
            this.LbMusic = new System.Windows.Forms.ListBox();
            this.BtnSelectFolder = new System.Windows.Forms.Button();
            this.BtnClearList = new System.Windows.Forms.Button();
            this.CbAllDirectory = new System.Windows.Forms.CheckBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
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
            // FParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.CbAllDirectory);
            this.Controls.Add(this.BtnClearList);
            this.Controls.Add(this.BtnSelectFolder);
            this.Controls.Add(this.LbMusic);
            this.Name = "FParams";
            this.Text = "Настройки";
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
    }
}