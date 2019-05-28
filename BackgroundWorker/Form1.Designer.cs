namespace BackgroundWorker
{
    partial class frmMain
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
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.cmdStart = new System.Windows.Forms.Button();
            this.lblDownloaded = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bgw
            // 
            this.bgw.WorkerReportsProgress = true;
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 25);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(776, 10);
            this.progress.TabIndex = 2;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(12, 41);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 3;
            this.cmdStart.Tag = "";
            this.cmdStart.Text = "Download";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // lblDownloaded
            // 
            this.lblDownloaded.Location = new System.Drawing.Point(548, 46);
            this.lblDownloaded.Name = "lblDownloaded";
            this.lblDownloaded.Size = new System.Drawing.Size(240, 13);
            this.lblDownloaded.TabIndex = 5;
            this.lblDownloaded.Text = "-/- MB";
            this.lblDownloaded.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(12, 9);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(130, 13);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "The.Witcher.S01E01.mkv";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(93, 46);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 4;
            // 
            // cmdClose
            // 
            this.cmdClose.FlatAppearance.BorderSize = 0;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmdClose.Location = new System.Drawing.Point(778, 0);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(22, 22);
            this.cmdClose.TabIndex = 6;
            this.cmdClose.Text = "x";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 75);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblDownloaded);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label lblDownloaded;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button cmdClose;
    }
}

