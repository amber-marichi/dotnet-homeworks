using System;
using System.Threading;

namespace Задание3
{
    class Program
    {
        static int CountRoad(int x)
        {
            if(x == 0)
            {
                return 1;
            }
            else
            {
                return x * CountRoad(x - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Пожалуйста, введите количество точек доставки: ");
            int delivery = Int32.Parse(Console.ReadLine());

            int variants = CountRoad(delivery);
            Console.WriteLine("всего может быть {0} вариантов маршрута", variants);
            Console.ReadLine();
        }
    }
}
