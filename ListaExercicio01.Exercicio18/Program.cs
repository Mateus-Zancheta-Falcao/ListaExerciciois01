using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Informe 3 valores inteiros e descubra sua ordem decrescente.- ");

            Console.WriteLine("Valor 1: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor 2: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor 3: ");
            int C= Convert.ToInt32(Console.ReadLine());

            if (A >= B && A >= C && B >= C)
            {
                Console.WriteLine($"Ordem decrescente {A}, {B}, {C}");
            }
            else if (A >= B && A >= C && C >= B)
            {
                Console.WriteLine($"Ordem decrescente {A}, {C}, {B}");
            }
            else if(B >= A && B >= C && A >= C)
            {
                Console.WriteLine($"Ordem decrescente {B}, {A}, {C}");
            }
            else if(B >= A && B >= C && C >= A)
            {
                Console.WriteLine($"Ordem decrescente {B}, {C}, {A}");
            }
            else if (C >= A && C >= A && A >= B)
            {
                Console.WriteLine($"Ordem decrescente {C}, {A}, {B}");
            }
            else if (C >= A && C >= B && B >= A)
            {
                Console.WriteLine($"Ordem decrescente {C}, {B}, {A}");
            }


            Console.ReadKey();
        }
    }
}
