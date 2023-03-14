using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio01.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("- Padaria Hotpão - ");

            Console.WriteLine("\nInforme a quantidade de pães vendidos: ");
            int quantidade_paes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de broas vendidos: ");
            int quantidade_broas = Convert.ToInt32(Console.ReadLine());

            double TotalPaes = quantidade_paes * 0.12;
            double TotalBroas = quantidade_broas * 1.50;
            double TotalArrecadado = TotalPaes + TotalBroas;

            double valorGuardaConta = (TotalArrecadado * 10) / 100;
            double contaPoupanca = valorGuardaConta + TotalArrecadado;
            contaPoupanca = contaPoupanca - TotalArrecadado;

            Console.WriteLine($"\nForam vendidos {quantidade_paes} pães e {quantidade_broas} broas");
            Console.WriteLine($"\nO total arrecado foi: R${TotalArrecadado}");
            Console.WriteLine($"\nO total para ser depositado na conta poupança foi: R${contaPoupanca}");

            Console.ReadKey();
        }
    }
}
