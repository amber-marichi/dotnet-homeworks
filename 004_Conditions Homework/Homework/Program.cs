using System;
using System.Collections.Specialized;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Calculator!");
            //Задание 2. Напишите программу - консольный калькулятор.

            Console.Write("Введите знак арифметитеского действия: ");

            double operand1 = 11, operand2 = 5, result = 0; 

            string sing = Console.ReadLine();

            switch (sing)
            {
                case "+":
                    {
                        result = operand1 + operand2;
                        Console.WriteLine("Наш результат " + result);
                        break;
                    }
                case "-":
                    {
                        result = operand1 - operand2;
                        Console.WriteLine("Наш результат " + result);
                        break;
                    }
                case "*":
                    {
                        result = operand1 * operand2;
                        Console.WriteLine("Наш результат " + result);
                        break;
                    }
                case "/":
                    {
                        if (operand1 == 0)
                         Console.WriteLine("Нельзя так делить");
                        else if (operand2 == 0)
                         Console.WriteLine("Нельзя так делить");
                        else
                         Console.WriteLine("Наш результат " + (result = operand1 / operand2));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Знак непонятен. Предлагаю попробовать как-нибудь ещё");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
