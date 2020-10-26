using System;

namespace допЗадание
{
    class Printer
    {
        public virtual void Color()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public void Print(string value)
        {
            this.Color();
            Console.WriteLine(value);
        }
    }
    class YellowPrinter : Printer
    {
        public override void Color()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
    class RedPrinter : Printer
    {
        public override void Color()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Printer print = new Printer();
            print.Print("another color");
            YellowPrinter yelPrint = new YellowPrinter();
            Printer upPrint = yelPrint;
            yelPrint.Print("another color");
            RedPrinter redPrint = new RedPrinter();
            Printer upupPrint = redPrint;
            redPrint.Print("another color");

            Console.ReadLine();
        }
    }
}
