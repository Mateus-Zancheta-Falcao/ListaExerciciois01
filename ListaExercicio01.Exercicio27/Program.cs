using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            int valor2 = 1;
            int valor3 = 0;

            Console.WriteLine("- Fibonacci Sequence - \n");

            Console.Write("0,1,");

            for (int i = 0; i < 13; i++)
            {
                valor3 = valor1 + valor2;

                Console.Write($"{valor3},");
                valor1 = valor2;
                valor2 = valor3;

            }

            Console.ReadKey();
        }
    }
}
