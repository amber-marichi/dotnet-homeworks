using System;

namespace Задание3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цифру для равностороннего треугольника: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int y = 0; y <= N; y++)
            {
                for (int xSpace = N; xSpace > y; xSpace--)
                {
                    Console.Write(" ");
                }
                for (int xLeft = 0; xLeft < y; xLeft++)
                {
                    Console.Write("*");
                }
                for (int xRight = 0; xRight < y; xRight++)
                {
                    Console.Write("*");
                }
                Console.WriteLine()            }

            Console.ReadLine();
        }
    }
}
