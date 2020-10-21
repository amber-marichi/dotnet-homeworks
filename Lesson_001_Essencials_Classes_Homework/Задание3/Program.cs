using System;
using Задание3;

namespace Задание3
{
    class Book
    {
        Title title;
        Author author;
        Content content;

        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }
    }
    class Title
    {
        public string title;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    class Author
    {
        public string author;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(author);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    class Content
    {
        public string content;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введита имя автора книги");
        string titleInput = Console.ReadLine();
        Console.WriteLine("Введите название книги");
        string authorInput = Console.ReadLine();
        Console.WriteLine("Про что книга?");
        string contentInput = Console.ReadLine();
        Console.Clear();

        Title myTitle = new Title();
        myTitle.title = titleInput;

        Author myAuthor = new Author();
        myAuthor.author = authorInput;

        Content myContent = new Content();
        myContent.content = contentInput;

        Book myBook = new Book(myTitle, myAuthor, myContent);
        myBook.Show();

        Console.Read();
        }
    }
}
