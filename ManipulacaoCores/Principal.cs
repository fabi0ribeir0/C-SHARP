using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulacaoCores
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            lblRed.BackColor = Color.Red; lblGreen.BackColor = Color.Green; lblBlue.BackColor = Color.Blue;
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            lblRed.Text = tbRed.Value.ToString();
            Cor.mudaCor(retangulo, tbRed, tbGreen, tbBlue);
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            lblGreen.Text = tbGreen.Value.ToString();
            Cor.mudaCor(retangulo, tbRed, tbGreen, tbBlue);
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            lblBlue.Text = tbBlue.Value.ToString();
            Cor.mudaCor(retangulo, tbRed, tbGreen, tbBlue);
        }
    }
}
