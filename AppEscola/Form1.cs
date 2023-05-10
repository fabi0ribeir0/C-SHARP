using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //sempre chamar a data atual ao executar
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblNome.Text = Program.usuario;

            dtData.Text = DateTime.Now.ToString();
        }

        //Metodos
        public void Status()
        {
            if (media >= 7)
            {
                lblSituacao.Text = $"Auno {Program.usuario} APROVADO!";
                lblSituacao.ForeColor = Color.DarkGreen;
            }
            else if (media >= 5 && media < 7)
            {
                lblSituacao.Text = $"Auno {Program.usuario} em RECUPERAÇÃO!";
                lblSituacao.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblSituacao.Text = $"Auno {Program.usuario} REPROVADO!";
                lblSituacao.ForeColor = Color.DarkRed;
            }

        }

        public void resultado()
        {            
            nota1 = nudNota1.Value;
            nota2 = nudNota2.Value;
            nota3 = nudNota3.Value;
            nota4 = nudNota4.Value;
            media = (nota1 + nota2 + nota3 + nota4) / 4m;

            lblMedia.Text = media.ToString("F");// dessa forma mostra apenas duas casas decimais
        }
        
        //Variaveis Global
        decimal nota1, nota2, nota3, nota4, media;
                
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            resultado();
            Status();
        }


    }
}
