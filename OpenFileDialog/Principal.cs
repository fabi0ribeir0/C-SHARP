using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDialog
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog open = new System.Windows.Forms.OpenFileDialog();

            open.InitialDirectory = @"C:\Users\Fabio\Pictures\";            
            open.Title = "Buscador";

            open.Filter = "Imagens | *jpg| Tranparentes | *png"; //Não pode ter esáço após a extensão 
            
            open.ShowDialog();

            if (open.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox1.Image = Image.FromFile(open.FileName);

            open.Dispose();
        }
    }
}
