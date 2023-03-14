using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vamos descobrir quantos dias você viveu!");

            Console.WriteLine("\nInforme seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            int TotalDias = idade * 365;

            Console.WriteLine($"\n{nome}, você já viveu {TotalDias} dias");

            Console.ReadKey();
        }
    }
}
