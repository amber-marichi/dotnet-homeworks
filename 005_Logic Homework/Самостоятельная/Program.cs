using System;

namespace Самостоятельная
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дополнительное задание 1. Напишите программу, которая будет выполнять проверку – 
            //является ли указанное число степенью двойки или нет.
            Console.WriteLine("Так является ли следующее число степенью двойки?");
            string x = Console.ReadLine();
            int N = Convert.ToInt32(x);
            int check = 0;

            if((N != 0) && ((check = (N >> 1) & (~ N + 1)) == 0))
            {
                Console.WriteLine("Да, является степенью двойки");
            }
            else
            {
                Console.WriteLine("Нет, не является степенью двойки");
            }
            Console.ReadLine();
        }
    }
}
