using System;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Информация о массиве:");

            int[] array = { 5, 123, 44 };
            
            //наибольшее значение массива
            if (array[1] > array[2] && array[1] > array[0])
            {
                Console.WriteLine(array[1] + " - наибольшее значение");
            }
            else if(array[2] > array[1] && array[2] > array[0])
            {
                Console.WriteLine(array[2] + " - наибольшее значение");
            }
            else
            {
                Console.WriteLine(array[0] + " - наибольшее значение");
            }

            // наименьшее значение массива
            if (array[1] < array[2] && array[1] < array[0])
            {
                Console.WriteLine(array[1] + " - наименьшее значение");
            }
            else if (array[2] < array[1] && array[2] < array[0])
            {
                Console.WriteLine(array[2] + " - наименьшее значение");
            }
            else
            {
                Console.WriteLine(array[0] + " - наименьшее значение");
            }

            //общая сумма всех элементов
            Console.WriteLine((array[0] + array[1] + array[2]) + " - общая сумма");

            //среднее арифметическое всех элементов
            Console.WriteLine(((array[0] + array[1] + array[2]) / array.Length) + " - среднее арифметическое");

            //все нечетные значения
            int count = 0;
            for (int i = 0; i < array.Length; i++)
                if ((array[i] % 2) != 0)
                {
                    Console.Write(array[i]); Console.Write(" "); count++;
                }
            
            if (count == 1)
            {
                Console.WriteLine("является нечетным");
            }
            else if (count > 1)
            {
                Console.WriteLine("являются нечетными");
            }
            else
            {
                Console.WriteLine("все четные");
            }
            Console.Read();
        }
    }
}
