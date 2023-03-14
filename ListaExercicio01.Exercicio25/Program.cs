using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Calcule a tabuada usando N -\n");

            Console.WriteLine("Informe o valor: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int resultado = i * N;
                Console.WriteLine($"{i} x {N} = {resultado}N");
            }

            Console.ReadKey();
        }
    }
}
