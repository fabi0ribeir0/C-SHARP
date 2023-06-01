using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintDocument
{
    public partial class Form1 : Form
    {
        int largura, altura;
        public Form1()
        {
            InitializeComponent();
        }

        private void Impressora_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string texto = textBox1.Text;
            Font tipo_fonte = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            //Point local = new Point(50,50);

            Rectangle ret = new Rectangle(0, 100, largura, 40);

            StringFormat alinhar = new StringFormat();

            alinhar.Alignment = StringAlignment.Center;
            alinhar.LineAlignment = StringAlignment.Center;

            List<String> lista = new List<String>()
            {
                "1 - Carro",
                "2 - Avião",
                "3 - Moto"
            };

            e.Graphics.DrawString("Titulo", tipo_fonte, cor, ret, alinhar);

            int y = 160;

            foreach (string frase in lista)
            {
                e.Graphics.DrawString(frase, tipo_fonte, cor, new Point(100,y));
                y += 30;
            }

            

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Impressora.DefaultPageSettings.Bounds.X.ToString());
            listBox1.Items.Add(Impressora.DefaultPageSettings.Bounds.Y.ToString());
            listBox1.Items.Add(Impressora.DefaultPageSettings.Bounds.Width.ToString());
            listBox1.Items.Add(Impressora.DefaultPageSettings.Bounds.Height.ToString());

            //Preparar impressão 

            largura = Impressora.DefaultPageSettings.Bounds.Width;
            altura = Impressora.DefaultPageSettings.Bounds.Height;

            Impressora.Print();
        }

    }
}
