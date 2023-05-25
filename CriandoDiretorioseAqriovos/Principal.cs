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
        string caminho = @"C:\ARQ\BACKUP";
        public Principal()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Criar pasta
            
            if (Directory.Exists(caminho))
            {
                MessageBox.Show("EXISTE");
            }
            else { Directory.CreateDirectory(caminho); MessageBox.Show("Criado"); }

            //Directory
        }
    }
}
