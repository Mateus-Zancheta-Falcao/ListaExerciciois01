using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descubra se A + B é menos que C\n");

            Console.WriteLine("Informe o valor de A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de C: ");
            int C = Convert.ToInt32(Console.ReadLine());

            if (A + B < C)
            {
                int soma = A + B;

                Console.WriteLine($"\nC é maior que A + B, o valor foi {soma}, valor do C {C}");
            }
            else
            {
                int soma = A + B;

                Console.WriteLine($"\nC é menor que A + B, o valor foi {soma}, valor do C {C}");
            }

            Console.ReadLine();
        }
    }
}
