﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constantes
{
    public partial class Principal : Form
    {
            
        public Principal()
        {
            InitializeComponent();
            lblRodape.Text = ClasseStatic.rodaPE;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {   
            ClasseNormal cn = new ClasseNormal();

            MessageBox.Show(cn.nome);
        }

        private void btbStatic_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ClasseStatic.vers);
        }
    }
}
