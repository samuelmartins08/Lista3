using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numPos;

            do
            {
                Console.Write("Digite um número positivo: ");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out double numTemp) && numTemp > 0)
                {
                    numPos = numTemp;
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número positivo.");
                }
            } while (true);

            Console.WriteLine($"Você digitou o número positivo: {numPos}");
        }
    }

}


