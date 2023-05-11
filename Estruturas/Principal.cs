using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estruturas
{
    public partial class Principal : Form
    {//Global
        struct EstruturaPessoal
        {
            public string Nome;
            public string Sobre;
        }

        public Principal()
        {
            InitializeComponent();
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            EstruturaPessoal ep = new EstruturaPessoal();
            ep.Nome = "Fábio";
            ep.Sobre = "Ribeiro";

            MessageBox.Show($"Eu {ep.Nome} {ep.Sobre}, estou estudando estruturas");
        }
    }
}
