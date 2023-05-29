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

namespace SalvandoArquivosEmMeusDoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog();

            salvar.Title = "Gravar arquivo";
            salvar.Filter = "TXT|*.txt";
            salvar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (salvar.ShowDialog() == DialogResult.Cancel)
                return;

            string caminho = salvar.FileName;
            StreamWriter stream = new StreamWriter(caminho, false, Encoding.Default);

            stream.WriteLine(txtNomeArquivo.Text);
            
            stream.Dispose();

        }
    }
}
