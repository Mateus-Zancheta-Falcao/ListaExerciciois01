using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Descubra a média pondera -\n");

            Console.WriteLine("A primeira terá o peso de 5 e a segunda também será 5!");

            Console.WriteLine("Informe a primeira nota: ");
            double N1 = Convert.ToDouble(Console.ReadLine()); //N = notas

            Console.WriteLine("Informe a segunda nota: ");
            double N2 = Convert.ToDouble(Console.ReadLine());

            double MediaPonderada = (N1 * 1) + (N2 * 1) / 2;

            Console.WriteLine($"A média ponderada é: {MediaPonderada}");

            Console.ReadKey();
        }
    }
}
