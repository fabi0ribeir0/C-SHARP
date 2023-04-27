using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicou");
            //chlItens.Items.Add("Fábio", true);
            //chlItens.Items.Remove(chlItens.Items[0]);
            //MessageBox.Show(chlItens.CheckedItems.Count.ToString());

            //for (int i = 0; i < chlItens.CheckedItems.Count; i++)
            //{
            //    MessageBox.Show(chlItens.GetItemText(chlItens.Items[i]));
            //}

            foreach (var item in chlItens.CheckedItems)
            {
                MessageBox.Show(chlItens.GetItemText(item));
            }

        }

        private void chbAtivaBotao_CheckedChanged(object sender, EventArgs e)
        {
            btnMensagem.Visible = chbAtivaBotao.Checked;
        }
    }
}
