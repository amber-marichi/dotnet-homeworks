using Microsoft.VisualBasic;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Conditions!");
            //Задание 3. Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой
            //промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100]. Если да, то укажите, в какой именно промежуток.
            //пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков,
            //то выводится соответствующее сообщение.

            Console.WriteLine("Давайте проверим в какой из промежутков входит искомое число: [0-14] [15-35] [36-49] [50-100]");
            Console.WriteLine("Введи число - получи промежуток!");
            string entry = Console.ReadLine();

            int ourEntry = Convert.ToInt32(entry);

            if (ourEntry <= 100)
            {
                if (ourEntry >= 50)                    Console.WriteLine($"Число {entry} входит в промежуток от 50 до 100");
                else if (ourEntry >= 36)
                    Console.WriteLine($"Число {entry} входит в промежуток от 36 до 49");
                else if (ourEntry >= 15)
                    Console.WriteLine($"Число {entry} входит в промежуток от 15 до 35");
                else if (ourEntry >= 0)
                    Console.WriteLine($"Число {entry} входит в промежуток от 0 до 14");
                else
                    Console.WriteLine($"Число {entry} не входит ни в один из даных промежутков");
            }
            else
            Console.WriteLine($"Число {entry} не входит ни в один из даных промежутков");
            Console.ReadLine();
        }
    }
}
