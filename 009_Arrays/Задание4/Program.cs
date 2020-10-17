using System;

namespace Задание4
{
    class Program
    {
        static int[] BuildArray(int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            int newIndx = 1;
            newArray[0] = value;
            for (int i = 0; i < array.Length; i++)
            {
                newArray[newIndx++] = array[i];
            }
            return newArray;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Первый массив:");
            int[] array = { 20, 30, 40, 50, 60 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
            Console.Write("введите значение первого индекса Нового массива: ");
            int index = Int32.Parse(Console.ReadLine());
            array = BuildArray(array, index);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.Read();
        }
    }
}
