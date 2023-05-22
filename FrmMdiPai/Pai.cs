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
    }
}
