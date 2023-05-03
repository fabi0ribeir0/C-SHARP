using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            string frase = "Meu Curso de C# na zatec cursos";
            //lista.Items.Add(frase);
            //lista.Items.Add($"A frase acima possui {frase.Length} caracteres (contando com espaço)");

            lista.Items.Clear();

            foreach (char f in frase)
            {
                lista.Items.Add(f);
            }
        }

        private void btnForeach2_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            List<string> lista_nomes = new List<string>()
            {
                "leo", "fabio", "amanda", "alex", "maria", "joão"
            };

            foreach (string nome in lista_nomes)
            {
                lista.Items.Add(nome.ToUpper());
            }
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            List<string> lista_nomes = new List<string>()
            {
                "leo", "fabio", "amanda", "alex", "maria", "joão"
            };
            int i;
            bool teste = int.TryParse(txtNome.Text, out i);
            if (teste == false || i > 5)
            {
                MessageBox.Show("ESCOLHA DE 0 A 5");
                return;
            }

            lista.Items.Add(lista_nomes[i]);

        }
    }
}
