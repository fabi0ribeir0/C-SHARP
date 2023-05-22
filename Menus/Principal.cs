using Menus.Vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculadora calc = new FrmCalculadora();
            calc.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos produtos = new FrmProdutos();
            produtos.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendas.FrmVendas vendas = new Vendas.FrmVendas();
            vendas.ShowDialog();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro cadastro = new FrmCadastro();
            cadastro.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            menuCombo.Items.Add("Dia");
            menuCombo.Items.Add("Mês");
            menuCombo.Items.Add("Ano");
            menuCombo.Items.Add("Horas");
        }

        private void menuCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNome.Text = menuCombo.Text;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            FrmVendas frm = new FrmVendas();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
    }
}
