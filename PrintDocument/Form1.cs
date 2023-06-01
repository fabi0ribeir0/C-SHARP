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
        public Form1()
        {
            InitializeComponent();
        }

        private void Impressora_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string texto = textBox1.Text;
            Font tipo_fonte = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            Point local = new Point(50,50);

            e.Graphics.DrawString(texto, tipo_fonte, cor, local);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Impressora.Print();
        }

    }
}
