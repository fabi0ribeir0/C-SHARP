using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriandoDiretorioseAqriovos
{
    public partial class Principal : Form
    {
        string caminho = @"C:\ARQ\BACKUP\";
        string NomeArquivo = "Config.cfg";
        public Principal()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Criar pasta
            
            if (!Directory.Exists(caminho+NomeArquivo))
            {
                Directory.CreateDirectory(caminho);
                
                StreamWriter arquivo = new StreamWriter(caminho+NomeArquivo, false, Encoding.Default);

                arquivo.WriteLine(txtNome.Text);
                arquivo.WriteLine(dtData.Value.ToShortDateString());

                arquivo.Dispose();

                MessageBox.Show("Criado");
            }
            //else { MessageBox.Show("Ja existe"); }

        }
    }
}
