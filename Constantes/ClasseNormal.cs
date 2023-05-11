using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constantes
{
    internal class ClasseNormal
    {
        //Constante vSis
        public const string vSis = "V1.0";

        //Forma de instanciar uma constante 
        //Cria uma variavel e atribui a ela a constante 
        //dessa forma é possivel instanciar a variavel (que está com o valor da constante)
        public string nome
        {
            //set { } não pode ser usado com constante pois a constante não pode alterar o seu valor
            get { return vSis; }
        }
    }
}