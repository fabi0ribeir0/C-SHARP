using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaClasse
{
    public partial class Form1 : Form
    {
        int v = 30;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // instanciar 
            Pessoas p1 = new Pessoas();

            p1.nome = "fabio";
            p1.idade = 36;
            p1.altura = 1.76f;
            p1.nacionalidade = "BR";


            lblNome.Text = p1.nome.ToUpper();
            lblIdade.Text = Convert.ToString(p1.idade); //Converto para string
            lblAltura.Text = p1.altura.ToString(); //Converte para string
            lblNascionalidade.Text = p1.nacionalidade.ToString();
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            Pessoas mtd = new Pessoas();
            mtd.nome = "fabio";
            mtd.idade = 36;
            mtd.falar();
        }

        
        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            Pessoas p = new Pessoas();
            p.nome = "fábio";
            p.pular();
            p.falar();

        }
    }
}
