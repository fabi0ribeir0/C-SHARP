using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMegaSena
{
    public partial class FrmMegaSena : Form
    {
        public FrmMegaSena()
        {
            InitializeComponent();
        }

        private void sorteio()
        {
            Random rnd = new Random();
            int[] result = new int[6];
            string saida = "";



            for (int i = 0; i < result.Length; i++)
            {

                inicio:

                int numero = rnd.Next(1, 61);

                // Verifica se o número já foi gerado
                if (result.Contains(numero))
                    goto inicio; // se o número for repetido, gerar outro número

                result[i] = numero;
                saida += result[i] + " ";

            }

            lblResultado.Text = saida;

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            sorteio();
        }
    }
}
