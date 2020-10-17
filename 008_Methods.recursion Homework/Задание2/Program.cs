using System;
using System.Diagnostics.Tracing;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Задание2
{
    class Program
    {
        static int ShowLoan(int whole, int sum, int count)
        {
          
            int result = whole - sum;
            Console.WriteLine($"осталось погасить {result} грн.");
            Console.WriteLine($"осталось платежей {count}.");
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Кредит был взят на сумму 700 грн, необходимо погасить в 7 платежей.");
            int count = 7, remain = 700;
            while (remain > 0 && count > 0)
            {
                Console.Write("введите сумму: ");
                int cash = Int32.Parse(Console.ReadLine()); count--;
                int result = ShowLoan(whole: remain, sum: cash, count : count); remain = result; 
            }

            if (remain > 0)
            {
                Console.WriteLine("количество платежей исчерпано, сумма оставшегося долга {0} грн.", remain);
            }
           else if (remain < 0)
            {
                double overpay = 0 - remain;
                Console.WriteLine("переплата составляет {0} грн", overpay);
            }
           else
            {
                Console.WriteLine("долг погашен!");
            }

            Console.ReadLine();
        }
    }
}
