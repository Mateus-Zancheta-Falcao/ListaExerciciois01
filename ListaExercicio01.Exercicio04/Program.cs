using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Calculadora para o consumo de combustível por Km -\n");

            Console.Write("Informe a quilometragem inicial: ");
            double QuilometragemInicial = Convert.ToDouble(Console.ReadLine()); 

            Console.Write("Informe a quilometragem final: ");
            double QuilometragemFinal = Convert.ToDouble(Console.ReadLine()); 

            Console.Write("Informe a quantidade de combustível: ");
            double QuantidadeComb = Convert.ToDouble(Console.ReadLine());

            double Consumo = (QuilometragemInicial + QuilometragemFinal) / QuantidadeComb;

            Consumo = Math.Round(Consumo, 2);

            Console.WriteLine($"\nO consumo de combustível foi: {Consumo}Km ");

            Console.ReadKey();
        }
    }
}
