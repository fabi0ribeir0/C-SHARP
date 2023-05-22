using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMdiPai
{
    public partial class Pai : Form
    {

        public Pai()
        {
            InitializeComponent();
        }



        private void mDIFilhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilho frm = new FrmFilho(this);
            frm.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int larg = this.DisplayRectangle.Width;
            int alt = this.DisplayRectangle.Height;

            //MessageBox.Show(larg + "de largura por " + alt + " de altura.");

            //int bAltura = btnMuda.Size.Height/2;
            //int bLargura = btnMuda.Size.Width/2;

            btnMuda.Location = new Point(larg/2-btnMuda.Width/2, alt/2-btnMuda.Height/2);
        }
    }
}
