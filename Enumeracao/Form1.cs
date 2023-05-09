using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumeracao
{
    public partial class Form1 : Form
    {
        Enumerador pessoa;

        public Form1()
        {
            InitializeComponent();
            pessoa = new Enumerador(); //instanciando dessa forma não precisa 
                                                  //repetir para cada botão
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Enumerador data = new Enumerador();

            data.MostrarMes(Enumerador.meses.Novembro);
            
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            pessoa.Movimento(Enumerador.move.cima);
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            pessoa.Movimento(Enumerador.move.direita);
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            pessoa.Movimento(Enumerador.move.baixo);
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            pessoa.Movimento(Enumerador.move.esquerda);
        }
    }
}
