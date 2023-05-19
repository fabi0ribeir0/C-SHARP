using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaBaixa
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string url = "https://medicalway.com.br/";
            string termoBusca = txttermoBusca.Text;

            using (WebClient client = new WebClient())
            {
                try
                {
                    string conteudoPagina = client.DownloadString(url);

                    if (conteudoPagina.Contains(termoBusca))
                    {
                        MessageBox.Show("Termo Encontrado!");
                    }
                    else
                    {
                        MessageBox.Show("Termo não encontrado!");
                    }
                }
                catch (WebException ex)
                {

                    MessageBox.Show("Ocorreu um erro ao acessar o site: ");
                }
            }


        }
    }
}
