using System;

namespace Задание2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нечетные числа в промежутке от 3 до 20");
            int A = 3, B = 20, remain = 0;

            while (B > A)
            {
                remain = B % 2; 
                if (remain != 0)
                {
                    Console.WriteLine(B);
                }
                B--;
            }

            Console.ReadLine();
        }
    }
}
