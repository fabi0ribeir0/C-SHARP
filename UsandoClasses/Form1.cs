using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsandoClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string frase = "Meu texto";

            lblFrase.Visible = true;

            lblFrase.Text = $"O comprimento da frase: {frase} é  {Convert.ToString(frase.Length)}";
        }
    }
}
