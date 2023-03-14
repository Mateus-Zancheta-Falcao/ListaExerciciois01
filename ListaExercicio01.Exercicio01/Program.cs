using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Comprimento, Largura, Altura;

            Console.WriteLine("- Calculo da caixa de um retângulo -\n");

            Console.WriteLine("Informe o comprimento: ");
            Comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a largura: ");
            Largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o comprimento: ");
            Altura = Convert.ToDouble(Console.ReadLine());

            double Volume = Comprimento * Largura * Altura;

            Console.WriteLine($"\nO volume da caixa é: {Volume} cm");

            Console.ReadKey();
        }
    }
}
