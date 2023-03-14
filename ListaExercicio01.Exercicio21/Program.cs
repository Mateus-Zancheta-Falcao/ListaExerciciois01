using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int C;

            Console.WriteLine("Descubra se os dois valores são iguais ou não!\n");

            Console.WriteLine("Digite o primeiro valor: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int B = Convert.ToInt32(Console.ReadLine());

            if (A == B)
            {
                 C = A + B;

                Console.WriteLine($"\nSão iguais! O valor da soma é: {C}");
            }
            else
            {
                 C = A * B;

                Console.WriteLine($"\nNão são iguais! O valor da multiplicação é: {C}");
            }

            Console.ReadKey();
        }
    }
}
