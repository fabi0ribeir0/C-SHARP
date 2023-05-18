using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstanciandoObjeto
{
    public partial class Principal : Form
    {
        FrmCadastro cadastro = new FrmCadastro();
        FrmVendas vendas = new FrmVendas();
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            FrmCalculadora calc = new FrmCalculadora(txtNome.Text);
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Digite Um nome");
                txtNome.Focus();
                return;
            }

            calc.ShowDialog();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            cadastro.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            vendas.ShowDialog();
        }
    }
}
