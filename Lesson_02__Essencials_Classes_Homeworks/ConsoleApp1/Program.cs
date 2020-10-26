using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Converter
    {
        double Usd, Eur, Rub;

        public void toUAHConverter(string currency, double sum)
        {
            double result = 0;
            switch (currency)
            {
                case "USD":
                    result = sum * Usd; Console.WriteLine($"Ваш результат - {result} {currency}");
                    break;
                case "EUR":
                    result = sum * Eur; Console.WriteLine($"Ваш результат - {result} {currency}");
                    break;
                case "RUB":
                    result = sum * Rub; Console.WriteLine($"Ваш результат - {result} {currency}");
                    break;
            }
      
        }
        public void fromUAHConverter(string currency, double sum)
        {
            double result = 0;
            switch (currency)
            {
                case "USD":
                    result = sum / Usd; Console.WriteLine($"Ваш результат - {result} {currency}");
                    break;
                case "EUR":
                    result = sum / Eur; Console.WriteLine($"Ваш результат - {result} {currency}");
                    break;
                case "RUB":
                    result = sum / Rub; Console.WriteLine($"Ваш результат - {result} {currency}");
                    break;
            }
        }

        public Converter(double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ковертируем валюту из UAH в USD, EUR, RUB или наоборот");
            double usdToUah = 28.34;
            double eurToUah = 33.42;
            double rubToUah = 0.37;
            Converter inquire = new Converter(usdToUah, eurToUah, rubToUah);
            Console.Write("введите сумму ");
            double sum = double.Parse(Console.ReadLine());
            Console.Write("из какой валюты ");
            string currency1 = Console.ReadLine();
            Console.Write("в какую ");
            string currency2 = Console.ReadLine();
            if (currency1 == "UAH")
            {
                inquire.fromUAHConverter(currency2, sum);
            }    
            if (currency2 == "UAH")
            {
                inquire.toUAHConverter(currency1, sum);
            }
 
            Console.ReadLine();
        }
    }
}
