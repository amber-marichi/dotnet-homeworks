using System;

namespace Задание_2_Вар_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2. Напишите программу, которая будет выполнять проверку чисел на четность. 
            Console.WriteLine("Odd or even? Let's check your favorite number:");
            string num = Console.ReadLine();

            int numCheck = Convert.ToInt32(num);

            //Вариант 2:
            byte key = 254, disjCheck = 0;

            disjCheck = (byte)(numCheck | key);

            if (disjCheck != 255)
            {
                Console.WriteLine("This number is even");
            }
            else
            {
                Console.WriteLine("This number is odd");
            }
            Console.ReadLine();
        }
    }
}
