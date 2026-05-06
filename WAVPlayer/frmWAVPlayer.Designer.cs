namespace WAVPlayer
{
    partial class frmWAVPlayer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlMarquee = new System.Windows.Forms.Panel();
            this.lblMarquee = new System.Windows.Forms.Label();
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.lblPathLabel = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblRecentLabel = new System.Windows.Forms.Label();
            this.cmbRecent = new System.Windows.Forms.ComboBox();
            this.lblDrop = new System.Windows.Forms.Label();
            this.lblFileInfo = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pnlShortcuts = new System.Windows.Forms.Panel();
            this.lblShortcuts = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.ofdWAVFile = new System.Windows.Forms.OpenFileDialog();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlMarquee.SuspendLayout();
            this.grpFile.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlShortcuts.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.pnlMarquee);
            this.pnlMain.Controls.Add(this.grpFile);
            this.pnlMain.Controls.Add(this.pnlControls);
            this.pnlMain.Controls.Add(this.pnlShortcuts);
            this.pnlMain.Controls.Add(this.pnlStatus);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(18);
            this.pnlMain.Size = new System.Drawing.Size(530, 448);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Location = new System.Drawing.Point(18, 14);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(494, 58);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(494, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "♫  WAV 音效播放器";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblSubtitle.Location = new System.Drawing.Point(2, 34);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(494, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "WAV Sound Player  ·  F5 播放  F6 重複  F7 停止  Ctrl+O 開啟";
            // 
            // pnlMarquee
            // 
            this.pnlMarquee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlMarquee.Controls.Add(this.lblMarquee);
            this.pnlMarquee.Location = new System.Drawing.Point(18, 76);
            this.pnlMarquee.Name = "pnlMarquee";
            this.pnlMarquee.Size = new System.Drawing.Size(494, 28);
            this.pnlMarquee.TabIndex = 1;
            // 
            // lblMarquee
            // 
            this.lblMarquee.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblMarquee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(90)))), ((int)(((byte)(255)))));
            this.lblMarquee.Location = new System.Drawing.Point(8, 6);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(478, 18);
            this.lblMarquee.TabIndex = 0;
            // 
            // grpFile
            // 
            this.grpFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.grpFile.Controls.Add(this.lblPathLabel);
            this.grpFile.Controls.Add(this.txtPath);
            this.grpFile.Controls.Add(this.btnBrowse);
            this.grpFile.Controls.Add(this.lblRecentLabel);
            this.grpFile.Controls.Add(this.cmbRecent);
            this.grpFile.Controls.Add(this.lblDrop);
            this.grpFile.Controls.Add(this.lblFileInfo);
            this.grpFile.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.grpFile.Location = new System.Drawing.Point(18, 112);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(494, 168);
            this.grpFile.TabIndex = 2;
            this.grpFile.TabStop = false;
            this.grpFile.Text = " 🗂  音效檔案";
            // 
            // lblPathLabel
            // 
            this.lblPathLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F);
            this.lblPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblPathLabel.Location = new System.Drawing.Point(12, 24);
            this.lblPathLabel.Name = "lblPathLabel";
            this.lblPathLabel.Size = new System.Drawing.Size(76, 18);
            this.lblPathLabel.TabIndex = 0;
            this.lblPathLabel.Text = "檔案路徑";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.txtPath.Location = new System.Drawing.Point(12, 44);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(374, 25);
            this.txtPath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btnBrowse.Location = new System.Drawing.Point(392, 42);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(88, 26);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "📂 瀏覽";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblRecentLabel
            // 
            this.lblRecentLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F);
            this.lblRecentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblRecentLabel.Location = new System.Drawing.Point(12, 76);
            this.lblRecentLabel.Name = "lblRecentLabel";
            this.lblRecentLabel.Size = new System.Drawing.Size(76, 18);
            this.lblRecentLabel.TabIndex = 2;
            this.lblRecentLabel.Text = "最近使用";
            // 
            // cmbRecent
            // 
            this.cmbRecent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cmbRecent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRecent.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.cmbRecent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.cmbRecent.Location = new System.Drawing.Point(12, 96);
            this.cmbRecent.Name = "cmbRecent";
            this.cmbRecent.Size = new System.Drawing.Size(468, 25);
            this.cmbRecent.TabIndex = 2;
            this.cmbRecent.SelectedIndexChanged += new System.EventHandler(this.cmbRecent_SelectedIndexChanged);
            // 
            // lblDrop
            // 
            this.lblDrop.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F);
            this.lblDrop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblDrop.Location = new System.Drawing.Point(12, 126);
            this.lblDrop.Name = "lblDrop";
            this.lblDrop.Size = new System.Drawing.Size(300, 18);
            this.lblDrop.TabIndex = 3;
            this.lblDrop.Text = "💡 提示：可直接拖曳 .wav 檔案到視窗";
            // 
            // lblFileInfo
            // 
            this.lblFileInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F);
            this.lblFileInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            this.lblFileInfo.Location = new System.Drawing.Point(12, 144);
            this.lblFileInfo.Name = "lblFileInfo";
            this.lblFileInfo.Size = new System.Drawing.Size(468, 18);
            this.lblFileInfo.TabIndex = 4;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.pnlControls.Controls.Add(this.btnPlay);
            this.pnlControls.Controls.Add(this.btnLoop);
            this.pnlControls.Controls.Add(this.btnStop);
            this.pnlControls.Location = new System.Drawing.Point(18, 292);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(494, 64);
            this.pnlControls.TabIndex = 3;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(130)))));
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btnPlay.Location = new System.Drawing.Point(0, 6);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(148, 48);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "▶  播放一次";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(90)))), ((int)(((byte)(255)))));
            this.btnLoop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoop.FlatAppearance.BorderSize = 0;
            this.btnLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoop.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btnLoop.Location = new System.Drawing.Point(156, 6);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(148, 48);
            this.btnLoop.TabIndex = 4;
            this.btnLoop.Text = "🔁  重複播放";
            this.btnLoop.UseVisualStyleBackColor = false;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(312, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(148, 48);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "⏹  停止播放";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pnlShortcuts
            // 
            this.pnlShortcuts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlShortcuts.Controls.Add(this.lblShortcuts);
            this.pnlShortcuts.Location = new System.Drawing.Point(18, 364);
            this.pnlShortcuts.Name = "pnlShortcuts";
            this.pnlShortcuts.Size = new System.Drawing.Size(494, 26);
            this.pnlShortcuts.TabIndex = 4;
            // 
            // lblShortcuts
            // 
            this.lblShortcuts.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F);
            this.lblShortcuts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblShortcuts.Location = new System.Drawing.Point(0, 5);
            this.lblShortcuts.Name = "lblShortcuts";
            this.lblShortcuts.Size = new System.Drawing.Size(494, 18);
            this.lblShortcuts.TabIndex = 0;
            this.lblShortcuts.Text = "  ⌨  F5 播放   F6 重複   F7/ESC 停止   Ctrl+O 開啟檔案";
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Controls.Add(this.btnEnd);
            this.pnlStatus.Location = new System.Drawing.Point(18, 398);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(494, 34);
            this.pnlStatus.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.5F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblStatus.Location = new System.Drawing.Point(0, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(364, 20);
            this.lblStatus.TabIndex = 0;
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.5F);
            this.btnEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.btnEnd.Location = new System.Drawing.Point(370, -2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(124, 40);
            this.btnEnd.TabIndex = 6;
            this.btnEnd.Text = "✕  結束程式";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // frmWAVPlayer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(530, 448);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmWAVPlayer";
            this.Text = "♫ WAV 音效播放器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWAVPlayer_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmWAVPlayer_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmWAVPlayer_DragEnter);
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlMarquee.ResumeLayout(false);
            this.grpFile.ResumeLayout(false);
            this.grpFile.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlShortcuts.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlMarquee;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.GroupBox grpFile;
        private System.Windows.Forms.Label lblPathLabel;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblRecentLabel;
        private System.Windows.Forms.ComboBox cmbRecent;
        private System.Windows.Forms.Label lblDrop;
        private System.Windows.Forms.Label lblFileInfo;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel pnlShortcuts;
        private System.Windows.Forms.Label lblShortcuts;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.OpenFileDialog ofdWAVFile;
    }
}