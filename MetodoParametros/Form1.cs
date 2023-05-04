using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoParametros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            Calcular soma = new Calcular();

           txtRes.Text =soma.Adicao(10,5).ToString();
        }

        private void txtRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular sub = new Calcular();

            txtRes.Text = sub.Subtrair(5,10).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calcular mult = new Calcular();

            txtRes.Text = mult.Multiplicar(10,5).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calcular div = new Calcular();

            txtRes.Text = div.Dividir(5,10).ToString();
        }
    }
}
