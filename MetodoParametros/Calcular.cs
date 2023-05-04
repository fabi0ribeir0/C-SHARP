using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoParametros
{
    internal class Calcular
    {
        public int Adicao(int valor1, int valor2) //Cria variavel do tipo inteiro como parametro
        {
            return valor1 + valor2; //retorna ao parametro a soma das variaveis
                                    //Obrigatorio ter um retorno quando não for void
        }

        public int Subtrair(int valor1, int valor2)
        {
            return valor1 - valor2;
        }

        public int Multiplicar(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        public decimal Dividir(decimal valor1, decimal valor2)
        {
            return valor1 / valor2; 
        }

    }
}
