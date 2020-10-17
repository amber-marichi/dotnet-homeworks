using System;

namespace Задание3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цифру для прямоугольника: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int y = 0; y <= N; y++)
            {
                for (int x = 0; x <= N; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
