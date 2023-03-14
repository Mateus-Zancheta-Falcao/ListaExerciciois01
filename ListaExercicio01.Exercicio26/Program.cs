using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Sequência de valores -\n");

            Console.WriteLine("Informe um valor: ");
            int A = Convert.ToInt32(Console.ReadLine());

            int fatorial = 1;

            for (int i = A; i >= 1; i--)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial);

            Console.ReadKey();
        }
    }
}
