using System;

namespace Задание4
{
    class Invoice
    {
        public static int OrderNo = 0;
        public readonly int Account;
        public readonly string Customer;
        public readonly string Provider;

        string Article;
        int Quantity;

        private double Price()
        {
            int price = PriceList(Article);
            double priceNDS = (price * Quantity) * 1.2;
            return priceNDS; 
        }
        public Invoice(int account, string name, string provider, string article, int quantity)
        {
            OrderNo++;
            Account = account; Customer = name; Provider = provider; Article = article;  Quantity = quantity;
            double priceNDS = Price(); double noNDSprice = (PriceList(Article) * Quantity);
            Console.WriteLine("Заказ № " + OrderNo);
            Console.WriteLine($"Цена с НДС: {priceNDS} ({noNDSprice} без НДС)");
            Console.WriteLine(new string('*', 65));
        }
        private int PriceList(string article) =>
            article switch
            {
               "5671" => 80,
               "1255" => 300,
               "2224" => 10,
               "0120" => 613,
               "6111" => 130,
               "3030" => 500,
               "5013" => 440,
            };
    }
}
