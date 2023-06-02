using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomAleatorio
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //Random aleatorio = new Random();

            //lstLista.Items.Clear();

            //for (int i = 0; i < 10; i++)
            //{
            //    int resultado = aleatorio.Next(0,100);
            //    lstLista.Items.Add(resultado);
            //}

            for (int i = 0; i < 10; i++)
            {
                lstLista.Items.Add(cod());
            }

        }

        private string cod(int qtd = 30)
        {
            StringBuilder str = new StringBuilder();

            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVXZabcdefghijklmnopqrstuvxz";

            for (int i = 0; i < qtd; i++)
            {
                Random random = new Random(i);
                
                int x = random.Next(caracteres.Length);
                str.Append(caracteres[x]);

            }

            return str.ToString();
            
        }
    }
}
