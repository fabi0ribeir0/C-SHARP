using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseVirtual
{
    public partial class Principal : Form
    {
        Moto Moto = new Moto();
        Carro Carro = new Carro();
        public Principal()
        {
            InitializeComponent();
        }

        private void btnTeste1_Click(object sender, EventArgs e)
        {
            Carro.Buzinar();
            Moto.Buzinar(); //Base
        }
    }
}
