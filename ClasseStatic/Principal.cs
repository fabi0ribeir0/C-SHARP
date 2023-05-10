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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.Text = ClasseStatic.nomeSistema;
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            Novo vai = new Novo();
            vai.ShowDialog();
            this.Close();
        }

        //private void btnOK_Click(object sender, EventArgs e)
        //{
        //    ClasseNormal cn = new ClasseNormal();
        //    cn.nome = "Fábio";
        //    cn.MostraNome();

        //    ClasseStatic.sobreNome = "Lima";
        //    ClasseStatic.ExibirNome();

        //}
    }
}
