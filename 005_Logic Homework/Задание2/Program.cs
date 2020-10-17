using System;
using System.Reflection;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2. Напишите программу, которая будет выполнять проверку чисел на четность. 
            Console.WriteLine("Odd or even? Let's check your favorite number:");
            string num = Console.ReadLine();

            int numCheck = Convert.ToInt32(num);

            //Вариант 1:
            byte key = 1, conjCheck = 0;

            conjCheck = (byte)(numCheck & key);

            if(conjCheck == 0)
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
