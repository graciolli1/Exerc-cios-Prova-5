using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_Prova_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Fazer um programa para encontrar todos os números pares entre 1 e 100.
            int n1 = 0;
            while (n1 < 100)
            {
                n1 = n1 + 2;
                Console.WriteLine(n1);
            }
            Console.ReadKey();
        }
    }
}
