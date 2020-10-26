using System;

namespace Задание4
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
        {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ от версии \"Про\" или \"Эксперт\". Можно продолжить в базовом режиме.");
            string key = Console.ReadLine();
            DocumentWorker document = null;

            switch (key)
            {
                case "pro":
                    {
                        ProDocumentWorker proDoc = new ProDocumentWorker();
                        document = proDoc as DocumentWorker;
                        break;
                    }
                case "exp":
                    {
                        ExpertDocumentWorker expDoc = new ExpertDocumentWorker();
                        document = expDoc as DocumentWorker;
                        break;
                    }
                default:
                    {
                        document = new DocumentWorker();
                        break;
                    }
            }
            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();

            Console.ReadLine();
        }
    }
}
