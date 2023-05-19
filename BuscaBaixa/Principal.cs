using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace BuscaBaixa
{
    public partial class Principal : Form
    {
        private List<string> urlsImagens;
        private int indiceAtual;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // Carregar as URLs de imagem do arquivo texto para a lista urlsImagens
            urlsImagens = new List<string>();
            indiceAtual = 0;
            ExibirImagemAtual();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string url = $"https://{txtSite.Text}";
            string caminhoDestino = $"C:\\Users\\Fabio\\Documents\\img\\{txtSite.Text}.txt";

            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument document = web.Load(url);

                // Extrair todas as tags <img> do HTML
                var imagens = document.DocumentNode.Descendants("img");

                StringBuilder sb = new StringBuilder();

                foreach (var img in imagens)
                {
                    string urlImagem = img.GetAttributeValue("src", "");
                    sb.AppendLine(urlImagem);
                }

                File.WriteAllText(caminhoDestino, sb.ToString());
                MessageBox.Show("Exportado");

                // Carregar as URLs de imagem do arquivo de texto para a lista urlsImagens
                urlsImagens = File.ReadAllLines(caminhoDestino).ToList();
                indiceAtual = 0;
                ExibirImagemAtual();

            }
            catch (WebException ex)
            {
                MessageBox.Show("Ocorreu um erro ao acessar o site: " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar o arquivo de texto: " + ex.Message);
            }
        }

        private void ExibirImagemAtual()
        {
            if (indiceAtual >= 0 && indiceAtual < urlsImagens.Count)
            {
                // Carregar a imagem a partir da URL e atribuí-la ao PictureBox
                string urlImagemAtual = urlsImagens[indiceAtual];
                pictureBox1.Load(urlImagemAtual);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceAtual > 0)
            {
                indiceAtual--;
                ExibirImagemAtual();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (indiceAtual < urlsImagens.Count - 1)
            {
                indiceAtual++;
                ExibirImagemAtual();
            }
        }
    }
}
