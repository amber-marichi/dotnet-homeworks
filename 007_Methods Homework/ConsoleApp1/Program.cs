using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    class Program
    {
        //Задание 2. Создайте четыре метода для выполнения арифметических операций
        static decimal Add(decimal summand1, decimal summand2)
        {
            decimal sum = summand1 + summand2;
            return sum;
        }
        static decimal Sub(decimal dec1, decimal dec2)
        {
            decimal decline = dec1 - dec2;
            return decline;
        }
        static decimal Div(decimal div1, decimal div2)
        {
            decimal divide = div1 / div2;
            return divide;
        }
        static decimal Mul(decimal mult1, decimal mult2)
        {
            decimal multi = mult1 * mult2;
            return multi;
        }
        static void Main(string[] args)
        {
            bool operate = true;
            while (operate)
            {
                Console.WriteLine("Пожалуйста, введите 2 числа:");

                decimal entry1 = Convert.ToDecimal(Console.ReadLine());
                decimal entry2 = Convert.ToDecimal(Console.ReadLine());
              
                Console.WriteLine("а теперь введите одну из комманд: [+], [-], [/], [*]");

                var command = Console.ReadKey(true).KeyChar;

                switch (command)
                {
                    case '+':
                        {
                            decimal result = Add(entry1, entry2);
                            Console.WriteLine("результат равен {0}", result); 
                            break;
                        }
                    case '-':
                        {
                            decimal result = Sub(entry1, entry2);
                            Console.WriteLine("результат равен {0}", result); 
                            break;
                        }
                    case '*':
                        {
                            decimal result = Mul(entry1, entry2);
                            Console.WriteLine("результат равен {0}", result); 
                            break;
                        }
                    case '/':
                        {
                            if (entry1 != 0 && entry2 != 0)
                            {
                                decimal result = Div(entry1, entry2); 
                                Console.WriteLine("результат равен {0}", result);
                            }
                            else
                            {
                                Console.WriteLine("нельзя делить на ноль!"); 
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("команда не определена"); 
                            break;
                        }
                }
                Console.WriteLine();
                Console.WriteLine("нажмите кнопку для выхода, нажмите [Y] чтобы начать сначала");
                var opt = Console.ReadKey(true).KeyChar;
                switch (opt)
                {
                    case 'y':
                        {
                            Console.Clear(); operate = true;
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("thank you, goodbye");
                            operate = false;
                            break;
                        }
                }
            }
        }
    }
}
