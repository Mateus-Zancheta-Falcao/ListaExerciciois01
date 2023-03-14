using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Conversor de graus Celsius para graus Fahrenheit -\n");

            Console.WriteLine("Informe os graus Celsius: ");
            double Celsius = Convert.ToDouble(Console.ReadLine());

            double Fahrenheit = (Celsius * 1.8) + 32;

            Fahrenheit = Math.Round(Fahrenheit, 2);

            Console.WriteLine($"O grau Fahrenheit é: F° {Fahrenheit}");

            Console.ReadKey();

        }
    }
}
