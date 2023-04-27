using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuSistema
{
    public partial class Form1 : Form
    {

        // Converção e operadores aritiméticos

        int valor1, valor2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            bool verifica;
                      
            verifica = int.TryParse(txtParcela1.Text, out valor1);
            if (verifica == false)
            {
                MessageBox.Show("Caracter invalido no campo Valor 1, digite um numero");
            }
            verifica = int.TryParse(txtParcela2.Text, out valor2);
            if (verifica == false)
            {
                MessageBox.Show("Caracter invalido no campo Valor 2, digite um numero");
            }


            resultado = valor1 + valor2;
            txtTotal.Text = resultado.ToString();
        }
    }
}
