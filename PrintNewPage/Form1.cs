using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintNewPage
{
    public partial class Form1 : Form
    {
        //Config Pagina
        Font letra;
        SolidBrush cor;
        int y = 50;
        int numFrases = 1;
        bool isPrinting = false;
        int altura;

        public Form1()
        {
            InitializeComponent();
        }

        private void Imprimir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Adicionando paginas

            altura = Imprimir.DefaultPageSettings.Bounds.Height;

            while (numFrases <= 100)
            {
                e.Graphics.DrawString("Minha frase de número " + numFrases.ToString(), letra, cor, new Point(50,y));
                y += 30;
                numFrases++;

                if (y >= altura - 70)
                {
                    y = 50;
                    e.HasMorePages = true;
                    break;
                }

            }

            // Verifica se todas as páginas foram impressas
            if (numFrases > 100)
            {
                isPrinting = false;
            }
            else
            {
                //Continua a imnpressão na próxima página
                e.HasMorePages = true;
            }

            //Verifica se todas as páginas foram impressas
            if (!isPrinting)
            {
                //Fecha o programa após a impressão
                Close();
            }

        }

            

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            letra = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel);
            cor = new SolidBrush(Color.DarkBlue);

            numFrases = 1;
            isPrinting = true;

            if (cfgImpressao.ShowDialog() == DialogResult.Cancel)
                return;

            Imprimir.Print();
        }
    }
}
