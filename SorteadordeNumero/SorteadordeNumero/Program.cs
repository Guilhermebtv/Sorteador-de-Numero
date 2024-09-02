using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SorteadordeNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("SORTEADOR DE NÚMERO");
            Console.WriteLine("------------------------");
            Console.Write("Início: ");
            int.TryParse(Console.ReadLine(), out a);

            Console.Write("Fim: ");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("-------------------------");

            Console.SetCursorPosition(0, 5);
            Random gerador = new Random();
            int n = gerador.Next(a, b + 1);
            Console.WriteLine("Sorteando ...");
            Thread.Sleep(3000);
            Console.SetCursorPosition(0, 5);
            Console.Write($"Entre {a} e {b} sorteei o valor {n}");
            Console.ReadKey();
        }
    }
}
