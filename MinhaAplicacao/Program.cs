using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaAplicacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string qualquerporra;

            Console.WriteLine("Aprendendo denovo SApoRRA");

            Console.Write("ESCREVE QUALQUER PORRA AQUI: ");
            qualquerporra = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($" VOCE ESQUERVEU: {qualquerporra}");
            Console.ReadKey();
        }
    }
}
