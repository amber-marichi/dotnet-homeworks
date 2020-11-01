using System;

namespace Задание4
{
    class Article
    {

        public string Name;
        private string Provider;
        private int Price;

        public Article(string name, string provider, int price)  
        {
            Name = name; 
            Provider = provider;
            Price = price;
        }
        public string goodDescr()
        {
            return string.Format($"{Name} от магазина {Provider} ценой {Price}");
        }
    }
        class Store
    {
            
            Article[] amount = new Article[5];
                
            public Store(Article a1, Article a2, Article a3, Article a4, Article a5)
            {
            amount[0] = a1;
            amount[1] = a2;
            amount[2] = a3;
            amount[3] = a4;
            amount[4] = a5;
        }
            public string this[int index]
        {
            get
            {
                if (index >= 0 && index < amount.Length)
                    return amount[index].goodDescr();
                else
                    return "Товара с таким индексом нет.";
            }
        }
        public string this[string index] 
        {
            get
            {
                for (int i = 0; i < amount.Length; i++)
                    if (amount[i].Name == index)
                        return amount[i].goodDescr();

                return string.Format($"товар \"{index}\" не найден.");
            }
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Результат запросов:");
            Article article1 = new Article("полки книжные", "икеа", 250);
            Article article2 = new Article("диван", "Персия", 4000);
            Article article3 = new Article("стул", "икеа", 368);
            Article article4 = new Article("шкаф", "Вудстер", 770);
            Article article5 = new Article("аквариум", "Кусто", 12000);
            Store newStore = new Store(article1, article2, article3, article4, article5);

            Console.WriteLine(newStore[1]);
            Console.WriteLine(newStore["пальто"]);
            Console.WriteLine(newStore["шкаф"]);
            Console.WriteLine(newStore[4]);
            Console.WriteLine(newStore[10]);

            Console.ReadLine();
        }
    }
}
