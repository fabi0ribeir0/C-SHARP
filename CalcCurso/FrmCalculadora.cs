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
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void txtTela_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AgregarNumero(object sender, EventArgs e)
        {
            var botao = ((Button)sender);
            if (txtTela.Text == "0")
                txtTela.Text = "";

            txtTela.Text += botao.Text;
        }

    }
}
