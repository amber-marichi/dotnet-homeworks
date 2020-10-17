using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Задание1
{
    class Program
    {
        //Дополнительное задание. Создайте метод с именем Calculate, который принимает в качестве параметров 
        //три целочисленных аргумента и выводит на экран среднее арифметическое значений аргументов. 
        static int Calculate(int argm1, int argm2, int argm3)
        {
            int result = (argm1 + argm2 + argm3) / 3;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление среднего арифметического следующих 3-х целых чисел:");
            int entry1 = Convert.ToInt32(Console.ReadLine());
            int entry2 = Convert.ToInt32(Console.ReadLine());
            int entry3 = Convert.ToInt32(Console.ReadLine());


            int result = Calculate(entry1, entry2, entry3);
            Console.WriteLine("Результат - {0}", result);
            Console.ReadKey();
        }
    }
}
