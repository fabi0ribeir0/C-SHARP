using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseStatic
{
    public partial class Novo : Form
    {
        public Novo()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Principal volta = new Principal();
            this.Close();
            volta.ShowDialog();

        }
    }
}
