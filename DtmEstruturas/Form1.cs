using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DtmEstruturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAtual.Text = DateTime.Now.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int d = 0;
            int m = 0;
            int a = 0;

            d = int.Parse(txtDia.Text);
            m = int.Parse(txtMes.Text);
            a = int.Parse(txtAno.Text);


            //lblData.Text = DateTime.Today.ToString("yy");

            DateTime dt = new DateTime(a, m, d);

            lblData.Text = dt.DayOfYear.ToString();
            MessageBox.Show(dt.DayOfWeek.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblAtual.Text = DateTime.Now.ToString("dd/mm/yyyy \nhh:mm:ss");
        }
    }
}
