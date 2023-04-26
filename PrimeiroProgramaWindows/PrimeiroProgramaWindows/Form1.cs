using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProgramaWindows
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Usado para calcurar media entre 4 notas
         * As notas são inseridas pelo usuario no texbox
         * São verificadas caso não numero aparece menssagem de erro avisando que valor invalido
         * Caso a média seja 6 ou mais aluno aprovado, Aparece Label Media na cor verde
         * Caso a média seja entre 4 e 5,99 aluno em recuperação Aparece Label Media na cor laranja
         * Caso média seja menor que 4 aluno reprovado, Aparece Label Media na cor vermelha
         */
        private void btnCalculaMedia_Click(object sender, EventArgs e)
        {
            float nota1, nota2, nota3, nota4, media;
            bool verifica;
            string situacao;

            verifica = float.TryParse(txbNota1.Text, out nota1);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido na nota 1.");
                return;
            }

            verifica = float.TryParse(txbNota2.Text, out nota2);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido na nota 2.");
                return;
            }

            verifica = float.TryParse(txbNota3.Text, out nota3);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido na nota 3.");
                return;
            }

            verifica = float.TryParse(txbNota4.Text, out nota4);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido na nota 4.");
                return;
            }

            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Color corSituacao;

            if (media >= 6)
            {
                situacao = "APROVADO!";
                corSituacao = Color.Green;
            }
            else if (media < 6 && media >= 4)
            {
                situacao = "RECUPERAÇÃO!";
                corSituacao = Color.Orange;

            }
            else
            { 
                situacao = "REPROVADO!";
                corSituacao = Color.Red;
            }

            lblMedia.ForeColor = corSituacao;
            lblMedia.Text = string.Format($"Média: {Math.Round(media, 2)} - {situacao}");

        }




    }
}
