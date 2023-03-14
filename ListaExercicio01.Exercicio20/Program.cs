using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Descubra se o número é impar ou par -\n");

            Console.WriteLine("Informe um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("\nNúmero é par");
            }
            else
            {
                Console.WriteLine("\nNúmero é impar");
            }

            Console.ReadKey();
        }
    }
}
