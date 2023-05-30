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

            MessageBox.Show(Nomes.LastIndexOf("Teste 2").ToString());

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //List<int> listar = new List<int>()
            //{
            //    10, 30, 40, 20, 90, 5
            //};

            //foreach (int Nome in listar)
            //    lstLista.Items.Add(Nome);

            //      HashSet
            HashSet<string> Set = new HashSet<string>() { "fabio", "elena", "monica" };

            Set.Add("fabio");


            MessageBox.Show(Set.Count.ToString());
        }
    }
}
