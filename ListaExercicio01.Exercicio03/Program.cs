using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;

            Console.WriteLine("- Calculo volume de um Cilindro -\n");

            Console.WriteLine("Informe o raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double Volume = pi * (raio * raio) * altura;
            //double Volume = pi * Math.Pow(raio,2) * altura;

            Console.WriteLine($"\nVolume do cilindro é: {Volume}cm");

            Console.ReadKey();
        }
    }
}
