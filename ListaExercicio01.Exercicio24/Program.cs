using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            Console.WriteLine("- Soma de todos os números ímpares e multiplos de 3 - \n");

            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);

            Console.ReadKey();
        }
    }
}
