using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 200; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
