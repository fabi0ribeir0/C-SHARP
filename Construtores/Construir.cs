using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construtores
{
    internal class Construir
    {
        string _nome;
        int _idade;

        //Construtores (tipos especiais de metodos)
        public Construir(string nome, int idade)// Observe abaixo
        {
            _nome = nome; // a variavel _nome rece a variavel nome (definido no COSNTRUTOR)
            _idade = idade; //o mesmo vale para _idade
        }

        //metodo
        public void teste2()
        {
            //Usamps as variavis locais na menssagem pois elas recebem as variaveis do 
            //CONSTRUTOR que por sua vez recebem os dados imputados do parametro dentro
            //do CONSTRUTOR
            MessageBox.Show($"Sou {_nome} e tenho {_idade} anos!".ToUpper()); 
        }

        public void teste2(string separador)
        {
            MessageBox.Show($"Sou {_nome} {separador} {_idade} ano!s");
        }

         
    }
}
