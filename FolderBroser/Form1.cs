using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderBroser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pastas = new FolderBrowserDialog();

            pastas.SelectedPath = @"C:\ARQ\";

            if (pastas.ShowDialog() == DialogResult.Cancel) return;

            textBox1.Text = pastas.SelectedPath;

        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            cd.Color = pictureBox1.BackColor;

            if (cd.ShowDialog() == DialogResult.Cancel) return;

            pictureBox1.BackColor = cd.Color;

        }
    }
}
