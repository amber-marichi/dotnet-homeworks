using System;

namespace Задание2
{
    abstract class AbstractHandler
    {
        abstract public void Open();
        abstract public void Create();
        abstract public void Change();
        abstract public void Save();

    }

    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open with MS Excel");
        }
        public override void Create()
        {
            Console.WriteLine("Create with MS Excel");
        }
        public override void Change()
        {
            Console.WriteLine("Change with MS Excel");
        }
        public override void Save()
        {
            Console.WriteLine("Save with MS Excel");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open with Notepad++");
        }
        public override void Create()
        {
            Console.WriteLine("Create with Notepad++");
        }
        public override void Change()
        {
            Console.WriteLine("Change with Notepad++");
        }
        public override void Save()
        {
            Console.WriteLine("Save with Notepad++");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open with MS Word");
        }
        public override void Create()
        {
            Console.WriteLine("Create with MS Word");
        }
        public override void Change()
        {
            Console.WriteLine("Change with MS Word");
        }
        public override void Save()
        {
            Console.WriteLine("Save with MS Word");
        }
    }
    class Program
       
    {
        static void Main(string[] args)
        {
            string fileName = "Userfile.txt";

            Console.WriteLine(fileName);
            Console.WriteLine(new string('-', 25));
            AbstractHandler doc1 = null;

            if (fileName.EndsWith(".txt"))
                {
                TXTHandler docTxt = new TXTHandler();
                doc1 = docTxt as TXTHandler;
            }
            if (fileName.EndsWith(".xml"))
            {
                XMLHandler docXml = new XMLHandler();
                doc1 = docXml as XMLHandler;
            }
            if (fileName.EndsWith(".doc"))
            {
                DOCHandler docDOC = new DOCHandler();
                doc1 = docDOC as DOCHandler;
            }
            doc1.Open();
            doc1.Create();
            doc1.Change();
            doc1.Save();

            Console.ReadLine();
        }
    }
}
