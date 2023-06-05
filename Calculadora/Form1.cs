using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
            txtVisor.Focus();
        }
        decimal primeiro, segundo;
        decimal resultado = 0;

        private void txtVisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é um número, backspace ou a virgula
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && (e.KeyChar != ','))
            {
                // Ignora a tecla precionada, cancelando o evento
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && txtVisor.Text.Contains(','))
            {
                // Impede a inserção de vírgula se já houver uma presente
                e.Handled |= true;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string buttonText = button.Text;

            if (txtVisor.Text.Length < 16)
            {
                txtVisor.Text += buttonText;
            }
        }

        private void button8_Click(object sender, EventArgs e) // IGUAL
        {

            segundo = decimal.Parse(txtVisor.Text);
            txtSegundoVisor.Text = $"{txtSegundoVisor.Text}{txtVisor.Text}";
            
            if (txtSegundoVisor.Text.Contains('/'))
            {
                resultado = primeiro / segundo;
                txtSegundoVisor.Text = $"{primeiro}/{segundo} = {Math.Round(resultado, 4)}";
                txtSegundoVisor.MaxLength = 15;                
            }
            else if (txtSegundoVisor.Text.Contains('*'))
            {
                resultado = primeiro * segundo;
                txtSegundoVisor.Text = $"{primeiro}*{segundo} = {resultado}";
                txtSegundoVisor .MaxLength = 15;    
            }
            else if (txtSegundoVisor.Text.Contains('+'))
            {
                resultado = primeiro + segundo;
                txtSegundoVisor.Text = $"{primeiro}+{segundo} = {resultado}";
                txtSegundoVisor.MaxLength = 15;
            }
            else if (txtSegundoVisor.Text.Contains("-"))
            {
                resultado = primeiro - segundo;
                txtSegundoVisor.Text = $"{primeiro}-{segundo} = {resultado}";
                txtSegundoVisor.MaxLength = 15;
            }


            txtVisor.Clear();
            txtVisor.Focus();


        }

        private void btvVirgula_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string buttonText = button.Text;

            if (txtVisor.Text.Length < 16)
            {
                txtVisor.Text += buttonText;
                button.Enabled = false; // Desativa o botão após o clique
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //Captura o texto atual do txtbox
            string texto = txtVisor.Text;

            //Verifica se o texto não está vazio
            if (!string.IsNullOrEmpty(texto))
            {
                // Remove o último caractere
                txtVisor.Text = texto.Substring(0, texto.Length - 1);
            }
            
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txtSegundoVisor.Clear();
            txtVisor.Clear();
            txtVisor.Focus();
            primeiro = 0;
            segundo = 0;
            resultado = 0;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (resultado == 0)
            {
                primeiro = Decimal.Parse(txtVisor.Text);
                txtSegundoVisor.Text = primeiro.ToString() + "*";
                txtVisor.Text = "";
                txtVisor.Focus();
            }
            else
            {
                primeiro = resultado;
                txtSegundoVisor.Text = primeiro.ToString() + "*";
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (resultado == 0)
            {
                primeiro = Decimal.Parse(txtVisor.Text);
                txtSegundoVisor.Text = primeiro.ToString() + "-";
                txtVisor.Clear();
                txtVisor.Focus();
            }
            else
            {
                primeiro = resultado;
                txtSegundoVisor.Text = primeiro.ToString() + "-";
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (resultado == 0)
            {
                primeiro = Decimal.Parse(txtVisor.Text);
                txtSegundoVisor.Text = primeiro.ToString() + "+";
                txtVisor.Text = "";
                txtVisor.Focus();
            }
            else
            {
                primeiro = resultado;
                txtSegundoVisor.Text = primeiro.ToString() + "+";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (resultado == 0)
            {
                primeiro = Decimal.Parse(txtVisor.Text);
                txtSegundoVisor.Text = primeiro.ToString() + "/";
                txtVisor.Text = "";
                txtVisor.Focus();
            }
            else
            {
                primeiro = resultado;
                txtSegundoVisor.Text = primeiro.ToString() + "/";
            }
            
        }



    }
}
