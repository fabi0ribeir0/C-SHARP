using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopFor
{
    public partial class Loop : Form
    {
        public Loop()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();   
            //                        i+=10 é o passo (de 10 em 10) ou seja i recebe i + 10 
            for (int i = 0; i <= 200; i+=10) 
            {
                lista.Items.Add(i.ToString());
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            int valor = 0;

            while (valor <=100)
            {
                lista.Items.Add(valor);
                valor++;
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            int teste = 0;

            do 
            {
                teste++;
                lista.Items.Add(teste);
            } while (teste <10);

        }
    }
}
