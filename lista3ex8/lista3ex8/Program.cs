using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
           
            for (int i = 1; i <= 100; i++)
            {

                soma = soma + i;


                Console.WriteLine("{0} intervalo:{1}", soma, i);

            }

        }
    }
}
