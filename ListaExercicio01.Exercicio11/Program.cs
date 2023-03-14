using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Descubra se o número é primo -\n");

            Console.WriteLine("Informe um número que deseja: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInforme o valor do divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            if (numero % divisor == 0)
            {
                Console.WriteLine("\nNúmero é primo");
            }
            else
            {
                Console.WriteLine("\nNúmero não é primo");
            }

            Console.ReadKey();
        }
    }
}
