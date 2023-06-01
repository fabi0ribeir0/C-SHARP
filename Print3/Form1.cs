using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Print3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font tipo_font = new Font("Times New Roman", 20, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.FromArgb(90, 0, 10));


            StringFormat alinhar = new StringFormat();
            alinhar.Alignment = StringAlignment.Near;
            alinhar.LineAlignment = StringAlignment.Far;

            Rectangle ret = new Rectangle(0,100,0,40);

            e.Graphics.DrawString("Titulo", tipo_font, cor, ret, alinhar);

            List<String> list = new List<String>()
            {
                "1 ajshjahlkjash",
                "2 kjkjfiejfefeok",
                "3 testetstete",
                "4 FIM"
            };
            int y = 160;

            //foreach (string item in list)
            //{
            //    e.Graphics.DrawString(item, new Font("Arial", 14, FontStyle.Regular), new SolidBrush(Color.Black), new Point(10, y));
            //    y += 90;
            //}

            string texto = "Entre os casos, um se destacou, o do médico e político Cândido Barata Ribeiro, que chegou a trabalhar na Corte durante dez meses julgando processos, mas depois precisou deixar o cargo por decisão do Senado. Na época, os indicados podiam assumir o trabalho antes da votação no Legislativo, mas os parlamentares recusaram o nome de Ribeiro porque ele não tinha formação jurídica. A legislação do período continha um vácuo e não especificava esse requisito, falando apenas na exigência de “notável saber” para candidatos ao STF, mas a norma vigente hoje estipula a regra e impõe a necessidade de “notável saber jurídico”.\r\n\r\nEm geral, a rejeição de um indicado por parte do Senado não é comum porque, entre outras coisas, o governo costuma sondar os parlamentares e o próprio STF a respeito de como é recebido o nome que o presidente da República pretende indicar. São muitas as tratativas que se desenrolam nos bastidores para garantir a articulação necessária à aprovação do nome na Casa, o que faz com que o processo seja eminentemente político.\r\n\r\nQuando o nome é aprovado por parte do plenário do Senado, cabe ao presidente da República publicar um decreto de nomeação para formalizar o nome do jurista em questão como ministro do Supremo. A oficialização é registrada no Diário Oficial da União (DOU) e dá a largada para que a Corte organize a posse do mais novo membro do plenário.";

            e.Graphics.DrawString(texto, tipo_font, cor, new Rectangle(100, y, 600, 200));

            e.Graphics.DrawRectangle(new Pen(Color.Red, 2), new Rectangle(100,y,600, 250));
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
