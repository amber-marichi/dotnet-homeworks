using System;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;

namespace Задание4
{
    class Program
    {
        //Напишите метод, который будет определять:
        //1) является ли введенное число положительным или отрицательным.
        //2) Является ли оно простым (используйте технику перебора значений). 
        //3) Делится ли на 2, 5, 3, 6, 9 без остатка. 

        static string PosCheck(int number)
        {
            if (number < 0)
            {
                return "это отрицательное число";
            }
            else if (number > 0)
            {
                return "это положительное число";
            }
            return "это чисто - ноль";
        }
        static void PrimeCheck(int number)
        {
            int counter = 0;
            int control = 2;
            int remain = 0;
            do
            {
                remain = number % control; control++; counter++;
            }
            while (remain != 0 && control < number);

            if (counter == (number - 2))
            {
                Console.WriteLine("это простое число");
            }
            else
            {
                Console.WriteLine("это не простое число");
            }
        }
        static void DivChek(int number)
        {
            bool flag = false;
            if (number == 0) 
            {
                Console.WriteLine("это число - ноль"); flag = true;
            }
            if ((number % 2) == 0)
            {
                Console.WriteLine("Число делится без остатка на 2"); flag = true;
            }
            if ((number % 3) == 0)
            {
                Console.WriteLine("Число делится без остатка на 3"); flag = true;
            }
            if ((number % 5) == 0)
            {
                Console.WriteLine("Число делится без остатка на 5"); flag = true;
            }
            if ((number % 6) == 0)
            {
                Console.WriteLine("Число делится без остатка на 6"); flag = true;
            }
            if ((number % 9) == 0)
            {
                Console.WriteLine("Число делится без остатка на 9"); flag = true;
            }

            if (flag == false)
            {
                Console.WriteLine("Число не делится без остатка на 2, 5, 3, 6, 9");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("введите число для проверки:");

            int entry = int.Parse(Console.ReadLine());

            string positive = PosCheck(entry);
            Console.WriteLine(positive);
            PrimeCheck(entry);
            DivChek(entry);
            Console.ReadLine();

        }
    }
}
