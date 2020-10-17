using System;

namespace Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 4
            Console.WriteLine("Введите количество точек для начала подсчет количества вариантов маршрута");
            int N = Convert.ToInt32(Console.ReadLine());
            int count = 1;

            do
            {
                count *= N--;
            }
            while (N > 0);

            Console.WriteLine("Всего {0} возможных варитов(-та)!", count);
            Console.ReadLine();
        }
    }
}
