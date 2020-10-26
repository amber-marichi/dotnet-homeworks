using System;

namespace Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Инвойс.");

            Invoice newInvoice = new Invoice(15155151, "Бульба О.", "Ken", "3030", 10);
            Invoice newInvoice2 = new Invoice(15155151, "Бульба О.", "Ken", "1255", 70);
            Invoice newInvoice3 = new Invoice(15155151, "Бульба О.", "Ken", "2224", 5);
            Invoice newInvoice4 = new Invoice(15155151, "Бульба О.", "Ken", "5013", 22);
            
            Console.Read();
        }
    }
}
