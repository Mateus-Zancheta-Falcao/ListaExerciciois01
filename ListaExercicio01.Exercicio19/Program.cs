using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura;

            Console.WriteLine("- Descubra seu IMC – Índice de Massa Corporal -\n");

            Console.WriteLine("Informe seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());


            //IMC = Índice de Massa Corporal
            double IMC = peso / (altura * altura);

            if (IMC < 18.5)
            {
                Console.WriteLine("\nAbaixo do peso.");
            }
            else if (IMC >= 18.5 && IMC < 25)
            {
                Console.WriteLine("\nPeso normal.");
            }
            else if (IMC >= 25 && IMC < 30)
            {
                Console.WriteLine("\nAcima do peso!");
            }
            else
            {
                Console.WriteLine("\nObeso");
            }

            Console.ReadKey();
        }
    }
}
