using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double DivisãoNotas = 0;
            double MediaFinal = 0, media;

            Console.WriteLine("- Calculo média harmônica - \n");

            Console.WriteLine("Informe a quantidade de notas: ");
            int quantidadeDeNotas = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantidadeDeNotas; i++)
            {
                Console.WriteLine("Informe uma nota: ");
                double nota = Convert.ToDouble(Console.ReadLine());

                media = 1 / nota;
                media = MediaFinal + media;
            }
            double MediaH = quantidadeDeNotas / MediaFinal;

            Console.WriteLine($"A média harmônica é: {MediaH}");

            Console.ReadLine();
        }
    }
}
