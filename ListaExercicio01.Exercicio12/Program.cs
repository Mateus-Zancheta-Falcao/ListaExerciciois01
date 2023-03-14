using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Calculo para descobrir a area de um terreno retangular - ");

            Console.WriteLine("\nInforme a base: ");
            double _base = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double area = _base * altura;

            Console.WriteLine($"\nA área do terreno é: {area}cm");

            Console.ReadKey();
        }
    }
}
