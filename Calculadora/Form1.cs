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

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }


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
        int contador = 0;


        private void btn0_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string buttonText = button.Text;

            if (txtVisor.Text.Length < 16)
            {
                txtVisor.Text += buttonText;
            }
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
    }
}
