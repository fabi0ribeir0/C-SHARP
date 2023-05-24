using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalcularFrete
{
    public partial class Principal : Form
    {
        string imgMoto = "C:\\Users\\Fabio\\Documents\\Estudos\\C-SHARP\\AppCalcularFrete\\Imagens\\moto.png";
        string imgCarro = "C:\\Users\\Fabio\\Documents\\Estudos\\C-SHARP\\AppCalcularFrete\\Imagens\\carro.png";
        string imgCaminhao = "C:\\Users\\Fabio\\Documents\\Estudos\\C-SHARP\\AppCalcularFrete\\Imagens\\caminhao.png";
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Load(imgMoto);
                    break;

                case 1: 
                    pictureBox1.Load(imgCarro);
                    break;

                case 2: 
                    pictureBox1.Load(imgCaminhao);
                    break;
            }


        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string local = txtLocalidade.Text;

            int moto = 40;
            int carro = 12;
            decimal litros = 1m;
            decimal caminhao = 3.5m;
            decimal distancia = Convert.ToDecimal(txtDistanciaKM.Text);
            decimal valorCombustivel = Convert.ToDecimal(txtValorCombustivel.Text);
            decimal multiplicador = 0;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    litros = moto;
                    multiplicador = 8;
                    break;

                case 1:
                    litros = carro;
                    multiplicador = 6 ;
                    break;

                case 2:
                    litros = caminhao;
                    multiplicador = 4;
                    break;
            }
            if (chbIdaVolta.Checked)            
                distancia*=2;
            
            decimal consumoCombustivel = (distancia / litros);
            decimal despesa = (consumoCombustivel * valorCombustivel);
            decimal total = (despesa * multiplicador);
            
            txtKMrodado.Text = distancia.ToString("f");
            txtConsumo.Text = consumoCombustivel.ToString("N1") + " LITROS";
            txtCustoKM.Text = (valorCombustivel / litros).ToString("f") + "R$";
            txtDespesa.Text = (despesa).ToString("f") + "R$";
            if (total <= 5)
            {
                total = 5;
            }
            txtTotal.Text = total.ToString("f");


        }
    }
}
