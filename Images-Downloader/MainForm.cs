using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images_Downloader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Асинхронная загрузка изображений
        private async Task DownloadImageAsync(string url)
        {
            string[] image_data = url.Split('/');
            string image_name = image_data[image_data.Length - 1];
            try
            {
                string dir_path = Path.GetFullPath(LocalDirPathBox.Text);
                if (!Directory.Exists(dir_path))
                {
                    Directory.CreateDirectory(dir_path);
                }
                HttpClientHandler httpClientHandler = new HttpClientHandler();
                httpClientHandler.AllowAutoRedirect = true;
                using (var client = new HttpClient(httpClientHandler))
                {
                    
                    var fileName = dir_path + "/" + "{0}" + image_name;
                    string fullPath = Path.GetFullPath(fileName);
                    using (var response = await client.GetAsync(url))
                    {

                        using (var imageFile = new FileStream(fileName, FileMode.Create))
                        {
                            await response.Content.CopyToAsync(imageFile);
                        }
                    }
                }
                DownloadProgress.Increment(1);
                if (DownloadProgress.Value == DownloadProgress.Maximum) {
                    MessageBox.Show("Загрузка завершена!");
                    DownloadProgress.Value = 0;
                    DownloadProgress.Visible = false;
                    Process.Start("explorer.exe", dir_path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Failed to load the image: {0}", ex.Message));
            }
        }

        private async void DownloadBtn_Click(object sender, EventArgs e)
        {
            if (ImagesUrlsList.Items.Count < 1)
            {
                MessageBox.Show("Изображения для выкачивания не обнаружены!");
                return;
            }
            DownloadProgress.Maximum = ImagesUrlsList.Items.Count;
            DownloadProgress.Value = 0;
            DownloadProgress.Visible = true;
            foreach (string url in ImagesUrlsList.Items) {
                await DownloadImageAsync(url);
            }
        }

        private void FileDirSelector_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string directoryPath = folderBrowserDialog.SelectedPath;
                string[] files = Directory.EnumerateFiles(directoryPath, "*.*", SearchOption.AllDirectories)
                            .Where(s => s.EndsWith(".txt") || s.EndsWith(".cfg") || s.EndsWith(".json"))
                            .ToArray();

                foreach (string file in files)
                {
                    string[] lines = File.ReadAllLines(file);
                    foreach (string line in lines)
                    {
                        MatchCollection matches = Regex.Matches(line, @"(http(s)?://.+?\.(jpg|jpeg|png|gif))");
                        foreach (Match match in matches)
                        {
                            ImagesUrlsList.Items.Add(match.Groups[1].Value);
                        }
                    }
                }

            }
        }

        private void ClipboardChecker_Tick(object sender, EventArgs e)
        {
            string clipboard_content = "";
            try {
                clipboard_content = Clipboard.GetText();
            } catch { }
            MatchCollection matches = Regex.Matches(clipboard_content, @"(http(s)?://.+?\.(jpg|jpeg|png|gif))");
            foreach (Match match in matches)
            {
                string potential_image_url = match.Groups[1].Value;
                if (!ImagesUrlsList.Items.Contains(potential_image_url)) {
                    ImagesUrlsList.Items.Add(potential_image_url);
                    SystemSounds.Beep.Play();
                }
            }
        }
    }
}
