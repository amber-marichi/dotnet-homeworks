using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цифру для треугольника: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int y = 0; y <= N; y++)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
