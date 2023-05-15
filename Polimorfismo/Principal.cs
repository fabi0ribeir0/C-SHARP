using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {            
            Carro carro = new Carro();

            Moto moto = new Moto();

            carro.acelerar();
            moto.acelerar();

        }
    }
}
