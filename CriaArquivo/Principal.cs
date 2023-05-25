using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CriaArquivo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            StreamWriter arq = new StreamWriter(@"C:\ARQ\Arquivo.txt"); //dessa forma reescreve o arquivo toda vez q o programa
                                                                        // é iniciado
            arq.WriteLine(textBox1.Text);

            arq.Dispose();

        }

        private void btnNaoApaga_Click(object sender, EventArgs e)
        {
            StreamWriter arq = new StreamWriter(@"C:\ARQ\Arquivo.txt", true, Encoding.Default);

            string data = DateTime.Now.ToString("G"); // fiz com variavel porem não precisava
            /*
             poderia ter feito desta forma:

                arq.WriteLine(txtBox1.Text + "-" + DateTime.Now("G")

             */

            arq.WriteLine(data + " - " +textBox1.Text); //Escreve no arquivo criado acima tudo que contem no textBox1

            arq.Dispose(); 
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            StreamReader ler = new StreamReader(@"C:\ARQ\Arquivo.txt");

            while (ler.EndOfStream)
            {
                listBox1.Items.Add(ler.ReadLine());
            }

            
            ler.Dispose();
        }
    }
}
