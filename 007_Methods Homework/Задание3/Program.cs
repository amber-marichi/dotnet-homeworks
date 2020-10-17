using System;

namespace Задание3
{
    class Program
    {
        //Задание 3. Напишите программу, которая будет выполнять конвертирование валют. 
        static double Conv(double amount, double course)
        {
            return amount * course;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("для начала введите сумму:");
            double entry1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("теперь введите курс валюты:");
            double entry2 = Convert.ToDouble(Console.ReadLine());

            double result = Conv(entry1, entry2);
            Console.WriteLine("после конвертирования {0} валюты по курсу {1} результат составляет {2}.", entry1, entry2, result);
            Console.ReadKey();
        }
    }
}
