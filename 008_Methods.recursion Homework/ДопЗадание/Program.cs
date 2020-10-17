using System;
using System.Security.Cryptography.X509Certificates;

namespace ДопЗадание
{
    class Program
    {
        static int Calculate(int X)
        {
            int result = X / 5;
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первое число ");
            int A = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            int B = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число ");
            int C = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"результатом деление на 5 числа {A} является " + Calculate(A));
            Console.WriteLine($"результатом деление на 5 числа {B} является " + Calculate(B));
            Console.WriteLine($"результатом деление на 5 числа {C} является " + Calculate(C));
            Console.ReadLine();
        }
    }
}
