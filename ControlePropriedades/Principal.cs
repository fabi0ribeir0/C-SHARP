using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlePropriedades
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblNome.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblNome.Text = txtNome.Text;
            lblNome.Text.ToUpper();

            lblNome.ForeColor = Color.Green;
            lblNome.BackColor = Color.White;
            lblNome.AutoSize = false;

            lblNome.Size = new Size(200, 60);

        }

        private void cbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNome.Checked)
            {
                lblNome.Visible = true;
            }else lblNome.Visible = false;
        }
    }
}
