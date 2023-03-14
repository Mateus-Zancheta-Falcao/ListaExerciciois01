using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Calculadora de salário -\n");

            Console.WriteLine("Informe o salário base: ");
            double SalarioBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas: ");
            double TotalVendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o total de comissão: ");
            double percentual = Convert.ToDouble(Console.ReadLine());

            double comissao = (TotalVendas * percentual) / 100;

            double SalarioFinal = SalarioBase + comissao;

            Console.WriteLine($"O salário total do vendedor será de: {SalarioFinal}");

            Console.ReadKey();
        }
    }
}
