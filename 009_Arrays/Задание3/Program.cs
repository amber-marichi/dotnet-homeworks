using Microsoft.VisualBasic;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Задание3
{
    class Program
    {
        static int[] MyReverse(int[] array)
        {
            int[] reverseArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reverseArray[i] = array[^(i + 1)] ;
            }
            return reverseArray;
            
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int[] subArray = new int[count];
            int subIdx = 0;

            for (int i = 0; i < count; i++)
            {
                if (index <= array.Length)
                {
                    int temp = index; subArray[subIdx++] = array[--temp]; ++index;
                }
                else
                {
                    subArray[subIdx++] = 1;
                }
            }
            return subArray;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Первый массив:");
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("[R] чтобы получить инвертированный массив.[N] чтобы получить Новый массив, где index - позиция в первом массиве, а count - размер Нового.");
            string command = Console.ReadLine(); 

            switch (command)
            {
                case "r":
                    Console.Clear();
                        array = MyReverse(array);
                                    for (int i = 0; i < array.Length; i++)
                                    {
                                        Console.WriteLine(array[i]);
                                    }
                        break;
                   
                case "n":
                    
                        Console.Write("введите index: ");
                        int index = Int32.Parse(Console.ReadLine());
                    if (index <= array.Length)
                    {
                        Console.Write("введите count: ");
                        int count = Int32.Parse(Console.ReadLine());
                        Console.WriteLine();

                        int[] newArray = SubArray(array, index, count);
                        for (int i = 0; i < newArray.Length; i++)
                        {
                            Console.WriteLine(newArray[i]);
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("такого индекса нет в Первом массиве.");
                    }
                    break;
            }
            
        }
        
    }   
}
