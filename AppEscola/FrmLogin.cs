using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public void entrar()
        {
            if (txtLog.Text == "")
            {
                MessageBox.Show("Digite um nome!");
                return;
            }
            if (txtPass.Text != "123")
            {
                MessageBox.Show("Senha incorreta");
                txtPass.Text = "";
                return;
            }

            Program.usuario = txtLog.Text;

            FrmPrincipal frm = new FrmPrincipal();

            frm.ShowDialog();

            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            entrar();            
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                entrar();
        }
    }
}
