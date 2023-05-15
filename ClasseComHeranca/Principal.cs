using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseComHeranca
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Lancha l = new Lancha();
            l.cor = "Verde";
            l.helice = "3 Faces";

            Moto m = new Moto();
            m.rodas = "Modelo Estrla";

        }
    }
}
