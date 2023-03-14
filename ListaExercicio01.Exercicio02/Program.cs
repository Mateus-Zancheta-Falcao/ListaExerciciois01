using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Conversor de graus Fahrenheit para graus Celsius -\n");

            Console.WriteLine("Informe os graus Fahrenheit: ");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());

            double Celsius = (Fahrenheit - 32) / 1.8;

            Celsius = Math.Round(Celsius, 2);

            Console.WriteLine($"\nO grau Celsius é: C° {Celsius}");

            Console.ReadKey();
        }
    }
}
