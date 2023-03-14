using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Calcula salário -\n");

            Console.WriteLine("Informe seu salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            double aumento = (salario * 15) / 100;
            double salario_aumento = salario + aumento;

            double desconto = (salario * 8) / 100;
            double salario_desconto = salario - desconto;

            Console.WriteLine($"\nSalário inicial: {salario}");
            Console.WriteLine($"Salário com aumento: {salario_aumento}");
            Console.WriteLine($"Salário final: {salario_desconto}");

            Console.ReadKey();
        }
    }
}
