using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, r;

            Console.WriteLine("Numero da tabuada a ser feita: ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num < 0)

                do
                {
                    Console.WriteLine("Você digitou um digito inválido, por favor digite um número positivo valido: ");
                    num = Convert.ToDouble(Console.ReadLine());
                } while (num < 0);

            for (int i = 1; i < 11; i++)
            {


                r = num * i;
                Console.WriteLine("{0} X {1}= {2} ", num, i, r);

            }
        }
    }
}
