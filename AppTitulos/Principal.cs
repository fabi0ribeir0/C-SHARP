using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AppTitulos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private string RunYoutubeDLCommand(string playlistUrl)
        {
            string command = $"c:\\Youtubedl\\youtube-dl --ignore-errors --skip-download --get-title --get-id --flat-playlist {playlistUrl}";

            var processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = $"/c {command}"
            };

            using (var process = new Process())
            {
                process.StartInfo = processStartInfo;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (!string.IsNullOrEmpty(output))
                {
                    return output;
                }
                else
                {
                    MessageBox.Show($"Erro ao executar o comando youtube-dl: {error}");
                    return null;
                }
            }
        }

        private string[] ExtractVideoTitles(string output)
        {
            string[] lines = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return lines.Select(line => line.TrimStart()).ToArray();
        }

        private void SaveTitlesToFile(string[] videoTitles)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivo de texto (*.txt)|*.txt;";
                saveFileDialog.Title = "Salvar títulos dos vídeos";
                saveFileDialog.FileName = "titles.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllLines(saveFileDialog.FileName, videoTitles);
                }
            }
        }

        private void btnExtrair_Click(object sender, EventArgs e)
        {
            string playlistUrl = txtPlaylistUrl.Text;
            string output = RunYoutubeDLCommand((playlistUrl));

            if (!string.IsNullOrEmpty(output))
            {
                string[] videoTitles = ExtractVideoTitles(output);

                if (videoTitles.Length > 0)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(videoTitles);
                    SaveTitlesToFile(videoTitles);
                    MessageBox.Show("Os títulos dos videos foram salvos!");
                }
                else MessageBox.Show("Não foi possível encontrar títulos de vídeos na playlist fornecida.");
            }
            else MessageBox.Show("Não foi possível obter os detalhes da playlist usando youtube-dl.");
        }
    }
}
