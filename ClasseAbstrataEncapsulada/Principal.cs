using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseAbstrataEncapsulada
{   
    public partial class Principal : Form
    {
        Calcular calcular = new Calcular();
        public Principal()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int pInicial = int.Parse(txtPreco.Text);

            int tipoProduto = 0;

            if (rdSuco.Checked) tipoProduto = 1;
            
            else if (rdTV.Checked) tipoProduto = 2;
            
            else if (rdRadio.Checked) tipoProduto = 3;

            MessageBox.Show($"O preço final é: {calcular.mostrarPreco(pInicial,tipoProduto)}");



        }
    }
}
