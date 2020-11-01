using System;
using System.Linq;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Случайный массив");
            Random random = new Random();
            int s = 0; int a = 0; int r = 0;

            int[] array = new int[8];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 50);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " "); 
            }

            Console.WriteLine();
            Console.WriteLine(new string ('#', 30));

            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
            }

            a = s / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    Console.WriteLine(array[i] + " - тут ноль");
                }
                else
                {
                    r = array[i] % 2;
                    if (r != 0)
                    {
                        Console.WriteLine(array[i] + " нечетное");
                    }
                    else
                    {
                        Console.WriteLine(array[i] + " четное");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('#', 15));

            int max = array.Max();
            int min = array.Min();
            Console.WriteLine(max + " наибольшее");
            Console.WriteLine(min + " наименьшее");
            Console.WriteLine(s + " сумма");
            Console.WriteLine(a + " среднее арифметическое");

            Console.Read();
        }
    }
}
