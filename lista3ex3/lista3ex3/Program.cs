using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3ex3
{

    internal class Program
    {
        static void Main()
        {
            char sexo;

            Console.Write("Digite o sexo (F ou M): ");

            while (true)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);
                sexo = tecla.KeyChar;

                if (sexo == 'F' || sexo == 'M')
                {
                    Console.WriteLine(sexo);
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite apenas 'F' ou 'M': ");
                }
            }

            Console.WriteLine($"Sexo registrado: {sexo}");
        }
    }
}