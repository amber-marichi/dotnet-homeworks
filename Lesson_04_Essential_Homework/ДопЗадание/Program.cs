using System;
using System.Reflection;

namespace ДопЗадание
{
    abstract class DocumentPart
        {
        public virtual string Content { get;  set; }
        abstract public void Show();
        }

    class Body : DocumentPart
    {
        public override string Content { get; set; }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    class Header : DocumentPart
    {
        public override string Content { get; set; }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    class Footer : DocumentPart
    {
        public override string Content { get; set; }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    class Document : DocumentPart
    {
        Header header;
        Body body;
        Footer footer;
        public Document(Header header, Body body, Footer footer)
        {
            this.header = header;
            this.body = body;
            this.footer = footer;
        }
        public override void Show()
        {
            header.Show();
            body.Show();
            footer.Show();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Body body = new Body();
            body.Content = "agreement";
            Header header = new Header();
            header.Content = "Contract";
            Footer footer = new Footer();
            footer.Content = "Parties";
            Document document = new Document(header, body, footer);
            document.Show();
            Console.ReadLine();
        }
    }
}
