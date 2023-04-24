using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EstruturasRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int p1 = 0;
            //int p2 = 1;
            //int pa = p1 + p2;

            //for (int i = 0; i < 10; i++)
            //{
            //    p1 = p2;
            //    p2 = pa;
            //    pa = p1 + p2;

            //    Console.WriteLine($"{pa},");
            //}

            //foreach (var item in DriveInfo.GetDrives())
            //{
            //    Console.WriteLine(item.Name);
            //}

            int i = 0;

            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
                
            //} while (i<=10);

            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();

        }
    }
}
