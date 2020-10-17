using System;

namespace доп.задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] array = new int[10];

            for(int n = 0; n < array.Length; n++)
            {
                array[n] = n * 10;
            }

            for(int n = array.Length - 1; n >= 0; n--)
            {
                Console.WriteLine(array[n]);
            }
            Console.Read();
        }
    }
}
