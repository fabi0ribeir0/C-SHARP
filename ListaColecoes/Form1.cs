using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaColecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
                    /*LIST*/

            List<string> Nomes = new List<string>();

            Nomes.Add("Teste 1");
            Nomes.Add("Teste 2");
            Nomes.Add("Teste 3");


            foreach (string Nome in Nomes)
            {
                lstLista.Items.Add(Nome);
            }

        }
    }
}
