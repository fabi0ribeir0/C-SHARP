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
using System.Net;
using Newtonsoft.Json.Linq;

namespace SaveName_PlaylistYoutube
{
    public partial class FrmPlaylist : Form
    {
        public FrmPlaylist()
        {
            InitializeComponent();
        }

        private bool IsValidPlaylistUrl(string url)
        {
            return url.StartsWith("https://www.youtube.com/playlist?") || url.StartsWith("https://youtube.com/playlist?");
        }

        private string GetPlaylistId(string url)
        {
            string playlistId = string.Empty;

            int startIndex = url.IndexOf("list=");
            if (startIndex != -1)
            {
                startIndex += 5;
                int endIndex = url.IndexOf('&', startIndex);
                playlistId = endIndex != -1 ? url.Substring(startIndex, endIndex - startIndex) : url.Substring(startIndex);
            }

            return playlistId;
        }

        private string GetApiResponse(string playlistId)
        {
            string apiKey = "AIzaSyCkRKueVwpwMPzUcWZpxqHW4myR1oNYfxM";
            string apiUrl = $"https://www.googleapis.com/youtube/v3/playlistItems?part=snippet&maxResults=50&playlistId={playlistId}&key={apiKey}";

            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                return client.DownloadString(apiUrl);
            }
        }

        private string[] GetVideoTitles(string apiResponse)
        {
            JObject json = JObject.Parse(apiResponse);
            JArray items = (JArray)json["items"];
            int itemCount = items.Count;

            string[] videoTitles = new string[itemCount];

            for (int i = 0; i < itemCount; i++)
            {
                videoTitles[i] = (string)items[i]["snippet"]["title"];
            }

            return videoTitles;
        }

        private void btnExtrair_Click(object sender, EventArgs e)
        {
            string playlistUrl = txtPlaylistUrl.Text;

            if (IsValidPlaylistUrl(playlistUrl))
            {
                string playlistId = GetPlaylistId(playlistUrl);

                if (!string.IsNullOrEmpty(playlistId))
                {
                    string apiResponse = GetApiResponse(playlistId);
                    string[] videoTitles = GetVideoTitles(apiResponse);

                    if (videoTitles.Length > 0)
                    {
                        SaveTitlesToFile(videoTitles);
                        MessageBox.Show("Os Títulos dos videos foram salvos com sucesso");
                    }
                    else MessageBox.Show("Não foi possível encontrar os títulos de vídeos na playlist fornecida.");
                }
                else MessageBox.Show("Não foi possível obter o ID da playlist apartir da URL fornecida.");
            }
            else MessageBox.Show("A URL fornecida não é uma URL válida de uma playlist do Youtube");
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
                    File.WriteAllLines(saveFileDialog.FileName, videoTitles, Encoding.UTF8);
                }
            }
        }
    }
}
