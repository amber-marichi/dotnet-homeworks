using System;
using System.Diagnostics.Tracing;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма чисел от 5 до 11");
            int A = 5, B = 11, sum = 0;

            while (B >= A)
            {
                sum += B; B--;
            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
