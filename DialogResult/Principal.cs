using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogResult
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
                                     //Texto            Título
            var res = MessageBox.Show("Desaja sair ?", "ENCERRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // por algum motivo tive que declarar o System.Windows.Form para funcionar
            if (res == System.Windows.Forms.DialogResult.Yes) 
                                                              
            {
                Application.Exit();
            }
        }
    }
}
