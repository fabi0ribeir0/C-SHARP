using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseParcial
{
    public partial class Principal : Form
    {
        //global

        ClasseNormal cn = new ClasseNormal();

        public Principal()
        {
            InitializeComponent();
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            cn.Nome = "Fábio";
            cn.Sobre = "Ribeiro de Lima";
            cn.mostrar();
        }
    }
}
