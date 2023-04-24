using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CalculaMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * MINE LEVANTAMENTO DE REQUISITOS
             * PRECISO SABER QUE É O ALUNO
             * PRECISO DAS 4 NOTAS DO ALUNO
             * CALCULAR A MÉDIA
             * MOSTRAR O CALCULO PARA O USUÁRIO
             * SE A MEDIA >= A 5 - ALUNO APROVADO
             * SE A MEDIA ESTIVER >= 4 && < QUE 5 - ALUNO EM RECUPERAÇÃO
             * SE A MEDIA < 4 - ALUNO REPROVADO
             * PERGUNTAR PARA O USUÁRIO SE DESEJA CALCULAR OUTRA MÉDIA
             */

            string nomeAluno;
            string outroAluno;
            float nota1, nota2, nota3, nota4, media;
            //
            //SOLICITA A ENTRADA DE DADOS PELO USUÁRIO

            do
            {
                Console.Write("Informe o nome do aluno: ");
                nomeAluno = Console.ReadLine();
                Console.Write("Informe a nota 1: ");
                nota1 = Convert.ToSingle(Console.ReadLine());
                Console.Write("Informe a nota 2: ");
                nota2 = Convert.ToSingle(Console.ReadLine());
                Console.Write("Informe a nota 3: ");
                nota3 = Convert.ToSingle(Console.ReadLine());
                Console.Write("Informe a nota 4: ");
                nota4 = Convert.ToSingle(Console.ReadLine());

                media = (nota1 + nota2 + nota3 + nota4) / 4f;

                Console.WriteLine("A média do aluno {0} é {1}", nomeAluno, media);

                if (media >= 6 )
                {
                    Console.WriteLine("Aluno {0} teve média {1} está APROVADO", nomeAluno, media);
                }
                else if ((media <6) && (media >= 4))
                {
                    Console.WriteLine("Aluno {0} teve média {1} está em RECUPERAÇÃO", nomeAluno, media);
                }
                else
                {
                    Console.WriteLine($"Aluno {nomeAluno} teve média {media} está REPROVADO");
                }

                Console.Write("\nDesaja calcular outra média? (s/n): ");
                outroAluno = Console.ReadLine().ToLower();

                while (((outroAluno != "s") && (outroAluno != "sim") && (outroAluno != "n") && (outroAluno != "não") && (outroAluno != "nao")))
                {
                    Console.Write("Opção invalida \nDigite: s ou n: ");
                    outroAluno = Console.ReadLine().ToLower();

                }

                Console.WriteLine("");

            } while ((outroAluno == "sim") || (outroAluno == "s"));


            //if (media >= 5)
            //{
            //    Console.WriteLine("Aluno {0} aprovado!", nomeAluno);
            //}
            //else if ((media >= 4) && (media < 5))
            //{
            //    Console.WriteLine("Aluno {0} em recuperação!", nomeAluno);
            //}
            //else
            //{
            //    Console.WriteLine("Aluno {0} reprovado!", nomeAluno);
            //}

            
            Console.ReadKey();


        }
    }
}
