using System;
using System.Diagnostics.Tracing;

namespace Fibonacci
{
    class Program
    {
        static int Fibonacci(int number, int A, int B)
        {
            number--;
            if (number == 0)
            { 
                return A;
            }
            else
            {
                return Fibonacci(number, B, A += B);
            }
            
        }
       
        static void Main(string[] args)
            {
                Console.Write("Пожалуйста, введите порядковый номер числа Фибоначчи ");
                int noFrom = Int32.Parse(Console.ReadLine());
                Console.WriteLine(Fibonacci(noFrom, 0, 1));
                Console.ReadLine();
            }
        
    }
}
