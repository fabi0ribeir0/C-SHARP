using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColecaoArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // ARRAYS,
            //10, 20, 30, 40, 50

            int[] valores = new int[5]; // de índice 5
            valores[0] = 10; // índice sempre inicia do 0
            valores[1] = 20;
            valores[2] = 30;
            valores[3] = 40;
            valores[4] = 50;

            lstQuadro.Items.Clear();

            for (int i = 0; i < 5; i++)
            {
                lstQuadro.Items.Add(valores[i]);
            }

            

        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            lstQuadro.Items.Clear();

            int[] valores = new int[] { 10, 20, 30, 40, 50, 60, 70 }; // de 0 à 6 (7 índices)

            foreach (int valor in valores)
            {
                lstQuadro.Items.Add(valor);
            }
            
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            lstQuadro.Items.Clear();

            int[] valores = new int[] { 10, 20, 30, 40, 50, 60, 70 }; // de 0 à 6 (7 índices)
            int valor1, valor2;
            valor1 = Convert.ToInt32(numUD1.Value);
            valor2 = Convert.ToInt32(numUD2.Value);

            lstQuadro.Items.Add(valores[valor1] + valores[valor2]);
            lstQuadro.Items.Add($"Acima o resultado da soma entre {valores[valor1]} e {valores[valor2]} ");

        }
    }
}