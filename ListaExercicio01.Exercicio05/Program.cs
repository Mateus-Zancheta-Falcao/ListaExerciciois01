using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;

            Console.WriteLine("- Calculo volume de uma Esfera -\n");

            Console.WriteLine("Informe o raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double Volume = (4 * pi * Math.Pow(raio, 3)) / 3;

            Volume = Math.Round(Volume, 2);

            Console.WriteLine($"\nVolume da esfera é: {Volume}cm");

            Console.ReadKey();

        }
    }
}
