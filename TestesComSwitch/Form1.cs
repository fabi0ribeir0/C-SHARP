using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesComSwitch
{
    public partial class Form1 : Form
    {

        int valor;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor = int.Parse(txtNota1.Text);

            //if (valor == 10) 
            //{
            //    lblResultado.Text = "é 10";
            //}
            //else if (valor == 11)
            //{
            //    lblResultado.Text = valor.ToString();
            //}
            //else
            //{
            //    lblResultado.Text = "Nem uma";
            //}

            //switch(valor) 
            //{
            //    case 10: //Caso for 10 -> 1º opção
            //        lblResultado.Text = "Igual a 10";
            //        break;

            //    case 11:
            //        lblResultado.Text = "Igual a 11";
            //        break;

            //    case 12:
            //        lblResultado.Text = "Igual a 12";
            //        break;

            //    default:
            //        lblResultado.Text = "Valor não encontrado";
            //        break;
            //}

            // Operador ternario

            lblResultado.Text = valor == 10 ? "SIM" : "NÃO";

        }
    }
}
