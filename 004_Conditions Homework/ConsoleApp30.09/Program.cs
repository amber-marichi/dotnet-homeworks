using System;

namespace ConsoleApp30._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели: 1-2-3-4-5-6-7: ");

            string myDay = Console.ReadLine();

            string dayOfWeek = myDay switch
            {
                "1" => "понедельник",
                "2" => "вторник",
                "3" => "среда",
                "4" => "четверг",
                "5" => "пятница",
                "6" => "суббота",
                "7" => "воскресенье",
                _ => "не знаю такого дня"
            };
            Console.WriteLine(dayOfWeek);
            Console.ReadLine();
        }
    }
}
