using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPrincipal
{
    public partial class Form1 : Form
    {
        float nota1, nota2, nota3, nota4, media;
        bool verifica;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            verifica = float.TryParse(txtNota1.Text, out nota1);
            if (verifica == false || nota1 > 10 ) 
            {
                MessageBox.Show("Valor de Nota1 Inválido\nDigite um número de 0 à 10");
                return;
            }
            verifica = float.TryParse(txtNota2.Text, out nota2);
            if (verifica == false || nota2 > 10 ) 
            {
                MessageBox.Show("Valor de Nota2 Inválido\nDigite um número de 0 à 10");
                return;
            }
            verifica = float.TryParse(txtNota3.Text, out nota3);
            if (verifica == false || nota3 > 10)
            {
                MessageBox.Show("Valor de Nota3 Inválido\nDigite um número de 0 à 10");
                return;
            }
            verifica = float.TryParse(txtNota4.Text, out nota4);
            if (verifica == false || nota4 > 10 )
            {
                MessageBox.Show("Valor de Nota4 Inválido\nDigite um número de 0 à 10");
                return;
            }

            media = (nota1 + nota2 + nota3 + nota4) /4;

            txtMedia.Text = media.ToString();

            if (media >= 7)
            {
                lblSituacao.Text = "APROVADO!";
                lblSituacao.ForeColor = Color.Green;
            }
            else if ((media < 7) && (media >= 5))
            {
                lblSituacao.Text = "RECUPERAÇÃO!";
                lblSituacao.ForeColor = Color.DarkOrange;
            }
            else
            { 
                lblSituacao.Text = "REPROVADO!";
                lblSituacao.ForeColor = Color.Red;
            }
            
        }
    }
}
