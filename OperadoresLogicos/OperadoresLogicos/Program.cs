using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 3;

            //bool valida = false;

            //if (i == 0)            
            //    Console.WriteLine("I = 0");
            //else
            //    Console.WriteLine("Primeira condição falsa!");


            //Console.WriteLine("Nova condição");

            //if (i == 1)
            //{
            //    Console.WriteLine("I = 1");
            //    Console.WriteLine("Segunda linha");
            //}
            //else if (i == 2) 
            //{
            //    Console.WriteLine("I = 2");
            //}
            //else 
            //{
            //    Console.WriteLine("Valor não corresponde");
            //}

            string nome;

            Console.Write("Informe o seu nome: ");
            nome = Console.ReadLine();

            switch (nome.ToLower())
            {
                case "fabio":
                    Console.WriteLine("Bem vindo!");
                    break;
                case "tobias":
                    Console.WriteLine("Avantasia!");
                    break;
                default:
                    Console.WriteLine("Não te conheço!");
                    break;
            }
            Console.ReadKey();

        }
    }
}
