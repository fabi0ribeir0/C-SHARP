using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaClasse
{
    internal class Pessoas
    {
        public string nome;
        public int idade;
        public float altura;
        public string nacionalidade;


         // metodo

        public void falar() //falar() é o metodo
        {
            MessageBox.Show($"Olá! sou {nome} e tenho {idade} anos");
        }
        public void pular()
        {
            idade = 30 + 20;
        }

    }
}
