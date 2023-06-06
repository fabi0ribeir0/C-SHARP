using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcCurso
{
    public partial class FrmCalculadora : Form
    {
        //Variaveis globais
        double numero1 = 0, numero2 = 0;
        char operador;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void AgregarNumero(object sender, EventArgs e)
        {
            var botao = ((Button)sender);
            if (txtTela.Text == "0")
                txtTela.Text = "";

            txtTela.Text += botao.Text;
            txtTela.MaxLength = 17;
        }
        private void ClicOperador(object sender, EventArgs e)
        {
            var botao = ((Button)sender);
            numero1 = Convert.ToDouble(txtTela.Text);
            operador = Convert.ToChar(botao.Tag);


            if (operador == '√')
            {
                numero1 = Math.Sqrt(numero1);
                txtTela.Text = numero1.ToString();
            }
            else if (operador == '²')
            {
                numero1 = Math.Pow(numero1, 2);
                txtTela.Text = numero1.ToString();
            }
            else if (operador == '±')
            {
                numero1 = numero1 * (-1);
                txtTela.Text = numero1.ToString();
            }
            else
            {
                txtTela.Clear();
            }            

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            string texto = txtTela.Text;
            if (!String.IsNullOrEmpty(texto))
            {
                txtTela.Text = texto.Substring(0, texto.Length - 1);
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            txtTela.Clear();
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtTela.Text.Contains(','))
            {
                txtTela.Text += ",";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTela.Text))
            {
                numero2 = Convert.ToDouble(txtTela.Text);
            }
            
            if (operador == '+')
            {
                txtTela.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txtTela.Text);
            }
            else if (operador == '-')
            {
                txtTela.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(txtTela.Text);
            }
            else if (operador == '*')
            {
                txtTela.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(txtTela.Text);
            }
            else if (operador == '/')
            {
                if (numero2 != 0)
                {
                    txtTela.Text = (numero1 / numero2).ToString();
                    numero1 = Convert.ToDouble(txtTela.Text);
                }
                else
                {
                    lblMsg.Visible = true;
                    txtTela.Clear();
                }                
            }
            else if (operador == '%')
            {
                txtTela.Text = (numero1*numero2/100).ToString();
            }

        }

    }
}
