namespace Images_Downloader
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DownloadProgress = new System.Windows.Forms.ProgressBar();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.LocalDirPathBox = new System.Windows.Forms.TextBox();
            this.LocalDirPathCaption = new System.Windows.Forms.Label();
            this.ImagesUrlsList = new System.Windows.Forms.ListBox();
            this.FileDirSelector = new System.Windows.Forms.Button();
            this.SingleCaption = new System.Windows.Forms.Label();
            this.ClipboardChecker = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.DownloadProgress);
            this.panel1.Controls.Add(this.DownloadBtn);
            this.panel1.Controls.Add(this.LocalDirPathBox);
            this.panel1.Controls.Add(this.LocalDirPathCaption);
            this.panel1.Controls.Add(this.ImagesUrlsList);
            this.panel1.Controls.Add(this.FileDirSelector);
            this.panel1.Controls.Add(this.SingleCaption);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 373);
            this.panel1.TabIndex = 0;
            // 
            // DownloadProgress
            // 
            this.DownloadProgress.Location = new System.Drawing.Point(12, 351);
            this.DownloadProgress.Name = "DownloadProgress";
            this.DownloadProgress.Size = new System.Drawing.Size(387, 10);
            this.DownloadProgress.TabIndex = 7;
            this.DownloadProgress.Visible = false;
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloadBtn.Location = new System.Drawing.Point(12, 311);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(387, 34);
            this.DownloadBtn.TabIndex = 6;
            this.DownloadBtn.Text = "Начать загрузку";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // LocalDirPathBox
            // 
            this.LocalDirPathBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocalDirPathBox.Location = new System.Drawing.Point(12, 275);
            this.LocalDirPathBox.Name = "LocalDirPathBox";
            this.LocalDirPathBox.Size = new System.Drawing.Size(387, 30);
            this.LocalDirPathBox.TabIndex = 5;
            this.LocalDirPathBox.Text = "Downloaded_Images";
            this.LocalDirPathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LocalDirPathCaption
            // 
            this.LocalDirPathCaption.AutoSize = true;
            this.LocalDirPathCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocalDirPathCaption.Location = new System.Drawing.Point(55, 244);
            this.LocalDirPathCaption.Name = "LocalDirPathCaption";
            this.LocalDirPathCaption.Size = new System.Drawing.Size(301, 28);
            this.LocalDirPathCaption.TabIndex = 4;
            this.LocalDirPathCaption.Text = "Путь до папки куда выкачивать";
            // 
            // ImagesUrlsList
            // 
            this.ImagesUrlsList.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImagesUrlsList.FormattingEnabled = true;
            this.ImagesUrlsList.ItemHeight = 17;
            this.ImagesUrlsList.Location = new System.Drawing.Point(12, 79);
            this.ImagesUrlsList.Name = "ImagesUrlsList";
            this.ImagesUrlsList.ScrollAlwaysVisible = true;
            this.ImagesUrlsList.Size = new System.Drawing.Size(387, 157);
            this.ImagesUrlsList.TabIndex = 2;
            // 
            // FileDirSelector
            // 
            this.FileDirSelector.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileDirSelector.Location = new System.Drawing.Point(12, 39);
            this.FileDirSelector.Name = "FileDirSelector";
            this.FileDirSelector.Size = new System.Drawing.Size(387, 34);
            this.FileDirSelector.TabIndex = 1;
            this.FileDirSelector.Text = "Выбрать папку с файлами содержащими ссылки";
            this.FileDirSelector.UseVisualStyleBackColor = true;
            this.FileDirSelector.Click += new System.EventHandler(this.FileDirSelector_Click);
            // 
            // SingleCaption
            // 
            this.SingleCaption.AutoSize = true;
            this.SingleCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingleCaption.Location = new System.Drawing.Point(80, 2);
            this.SingleCaption.Name = "SingleCaption";
            this.SingleCaption.Size = new System.Drawing.Size(236, 28);
            this.SingleCaption.TabIndex = 0;
            this.SingleCaption.Text = "Выкачивание из файлов";
            // 
            // ClipboardChecker
            // 
            this.ClipboardChecker.Enabled = true;
            this.ClipboardChecker.Interval = 1000;
            this.ClipboardChecker.Tick += new System.EventHandler(this.ClipboardChecker_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 398);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Загрузчик изображений";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LocalDirPathCaption;
        private System.Windows.Forms.ListBox ImagesUrlsList;
        private System.Windows.Forms.Button FileDirSelector;
        private System.Windows.Forms.Label SingleCaption;
        private System.Windows.Forms.ProgressBar DownloadProgress;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.TextBox LocalDirPathBox;
        private System.Windows.Forms.Timer ClipboardChecker;
    }
}

