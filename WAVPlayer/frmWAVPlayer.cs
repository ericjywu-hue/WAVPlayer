using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAVPlayer
{
    public partial class frmWAVPlayer : Form
    {
        private SoundPlayer activePlayer = null; // 追蹤目前使用中的播放器
        private bool isLooping = false;          // 追蹤是否為重複播放狀態
        private System.Windows.Forms.Timer marqueeTimer; // 跑馬燈計時器
        private string marqueeText = "";
        private int marqueeOffset = 0;

        public frmWAVPlayer()
        {
            InitializeComponent();
            InitializeRecentFiles();
            SetupMarqueeTimer();
            SetStatus("就緒 — 請選擇 WAV 檔案", StatusType.Info);
        }

        // ─── 狀態列輔助 ───────────────────────────────────────────
        private enum StatusType { Info, Success, Warning, Error }

        private void SetStatus(string message, StatusType type)
        {
            lblStatus.Text = message;
            if (type == StatusType.Success)
                lblStatus.ForeColor = Color.FromArgb(0, 200, 120);
            else if (type == StatusType.Warning)
                lblStatus.ForeColor = Color.FromArgb(255, 180, 0);
            else if (type == StatusType.Error)
                lblStatus.ForeColor = Color.FromArgb(255, 80, 80);
            else
                lblStatus.ForeColor = Color.FromArgb(160, 200, 255);
        }

        // ─── 最近使用檔案 ─────────────────────────────────────────
        private void InitializeRecentFiles()
        {
            // 從 Tag 中讀取之前儲存的清單 (簡易持久化)
            cmbRecent.Items.Insert(0, "— 最近使用檔案 —");
            cmbRecent.SelectedIndex = 0;
        }

        private void AddRecentFile(string path)
        {
            // 避免重複
            if (cmbRecent.Items.Contains(path)) return;
            if (cmbRecent.Items.Count > 10) cmbRecent.Items.RemoveAt(cmbRecent.Items.Count - 1);
            cmbRecent.Items.Insert(1, path);
        }

        // ─── 跑馬燈 ───────────────────────────────────────────────
        private void SetupMarqueeTimer()
        {
            marqueeTimer = new System.Windows.Forms.Timer { Interval = 80 };
            marqueeTimer.Tick += (s, e) =>
            {
                if (marqueeText.Length == 0) return;
                marqueeOffset = (marqueeOffset + 1) % (marqueeText.Length + 8);
                string display = (marqueeText + "        ").Substring(marqueeOffset % (marqueeText.Length + 8));
                lblMarquee.Text = display.Length > 50 ? display.Substring(0, 50) : display;
            };
        }

        private void StartMarquee(string text)
        {
            marqueeText = text;
            marqueeOffset = 0;
            marqueeTimer.Start();
        }

        private void StopMarquee()
        {
            marqueeTimer.Stop();
            lblMarquee.Text = "";
        }

        // ─── 瀏覽按鈕 ─────────────────────────────────────────────
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdWAVFile.Filter = "WAV Files (*.wav)|*.wav|All Files (*.*)|*.*";
            ofdWAVFile.Title = "選擇 WAV 音效檔";
            if (ofdWAVFile.ShowDialog() == DialogResult.OK)
            {
                LoadFile(ofdWAVFile.FileName);
            }
        }

        private void LoadFile(string path)
        {
            txtPath.Text = path;
            AddRecentFile(path);

            // 顯示檔案資訊
            try
            {
                var info = new FileInfo(path);
                string size = info.Length > 1024 * 1024
                    ? $"{info.Length / 1024.0 / 1024.0:F2} MB"
                    : $"{info.Length / 1024.0:F1} KB";
                lblFileInfo.Text = $"📄 {info.Name}   |   💾 {size}   |   📅 {info.LastWriteTime:yyyy-MM-dd}";
                SetStatus($"已載入：{info.Name}", StatusType.Success);
                StartMarquee($"♪  {info.Name}  ♪  {size}  ♪  ");
            }
            catch
            {
                lblFileInfo.Text = "";
            }

            // 停止舊的播放
            StopCurrentPlayer();
        }

        // ─── 最近使用下拉選單 ──────────────────────────────────────
        private void cmbRecent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRecent.SelectedIndex <= 0) return;
            string selected = cmbRecent.SelectedItem?.ToString() ?? "";
            if (File.Exists(selected))
                LoadFile(selected);
            else
                SetStatus("找不到該檔案", StatusType.Warning);
        }

        // ─── 播放一次 ─────────────────────────────────────────────
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!ValidatePath()) return;
            StopCurrentPlayer();
            try
            {
                activePlayer = new SoundPlayer(txtPath.Text);
                activePlayer.Load();
                activePlayer.Play();
                isLooping = false;
                SetStatus("▶  播放中...", StatusType.Success);
                UpdateButtonStates(playing: true);
            }
            catch (Exception ex)
            {
                SetStatus($"播放失敗：{ex.Message}", StatusType.Error);
            }
        }

        // ─── 重複播放 ─────────────────────────────────────────────
        private void btnLoop_Click(object sender, EventArgs e)
        {
            if (!ValidatePath()) return;
            StopCurrentPlayer();
            try
            {
                activePlayer = new SoundPlayer(txtPath.Text);
                activePlayer.PlayLooping();
                isLooping = true;
                SetStatus("🔁  重複播放中...", StatusType.Success);
                UpdateButtonStates(playing: true);
            }
            catch (Exception ex)
            {
                SetStatus($"播放失敗：{ex.Message}", StatusType.Error);
            }
        }

        // ─── 停止播放 ─────────────────────────────────────────────
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopCurrentPlayer();
            SetStatus("⏹  已停止", StatusType.Info);
            UpdateButtonStates(playing: false);
            StopMarquee();
        }

        private void StopCurrentPlayer()
        {
            activePlayer?.Stop();
            activePlayer = null;
            isLooping = false;
        }

        // ─── 輸入驗證 ─────────────────────────────────────────────
        private bool ValidatePath()
        {
            if (string.IsNullOrWhiteSpace(txtPath.Text))
            {
                SetStatus("⚠  請先選擇 WAV 檔案！", StatusType.Warning);
                txtPath.Focus();
                return false;
            }
            if (!File.Exists(txtPath.Text))
            {
                SetStatus("⚠  找不到指定的檔案！", StatusType.Error);
                return false;
            }
            if (!txtPath.Text.EndsWith(".wav", StringComparison.OrdinalIgnoreCase))
            {
                SetStatus("⚠  請選擇 WAV 格式的音效檔！", StatusType.Warning);
                return false;
            }
            return true;
        }

        // ─── 按鈕狀態更新（避免重複操作） ─────────────────────────
        private void UpdateButtonStates(bool playing)
        {
            btnPlay.Enabled = !playing || isLooping;
            btnLoop.Enabled = !playing || !isLooping;
            btnStop.Enabled = playing;
        }

        // ─── 拖曳放置 WAV 檔案 ────────────────────────────────────
        private void frmWAVPlayer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void frmWAVPlayer_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0 && files[0].EndsWith(".wav", StringComparison.OrdinalIgnoreCase))
                LoadFile(files[0]);
            else
                SetStatus("⚠  請拖入 WAV 格式檔案", StatusType.Warning);
        }

        // ─── 鍵盤快捷鍵 ───────────────────────────────────────────
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F5:
                    btnPlay_Click(this, EventArgs.Empty);
                    return true;
                case Keys.F6:
                    btnLoop_Click(this, EventArgs.Empty);
                    return true;
                case Keys.F7:
                case Keys.Escape:
                    btnStop_Click(this, EventArgs.Empty);
                    return true;
                case Keys.Control | Keys.O:
                    btnBrowse_Click(this, EventArgs.Empty);
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // ─── 結束程式 ─────────────────────────────────────────────
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ─── 關閉確認 ─────────────────────────────────────────────
        private void frmWAVPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCurrentPlayer();
            var result = MessageBox.Show(
                "確定要關閉 WAV 播放器嗎？",
                "關閉確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2 // 預設選「否」，防止誤關
            );
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}