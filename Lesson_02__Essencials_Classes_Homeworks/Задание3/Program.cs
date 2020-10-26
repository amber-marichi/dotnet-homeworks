using System;
using Задание3;

namespace Задание3
{
    class Employee
    {
        string FirstName, SecondName, Post;
        private float TaxAmount, FixedPay;
        public readonly float TaxIndex = 0.18f;
        bool Flag = true;

        private void TaxCalcucator(string occupy)
        {

            switch (occupy)
            {
                case "директор":
                    {
                        FixedPay = 20000; Flag = true;
                        break;
                    }
                case "менеджер":
                    {
                        FixedPay = 15000; Flag = true;
                        break;
                    }
                case "секретарь":
                    {
                        FixedPay = 14000; Flag = true;
                        break;
                    }
                case "работник":
                    {
                        FixedPay = 12000; Flag = true;
                        break;
                    }
                default:
                    {
                        Flag = false;
                        break;
                    }
            }
        }


        public Employee(string firstName, string secondName, string post)
        {
            FirstName = firstName;
            SecondName = secondName;
            Post = post;
            TaxCalcucator(post);
            TaxAmount = FixedPay * TaxIndex;
            float actual = FixedPay - TaxAmount;
            Console.Clear();

            if (Flag == true)
            {
                Console.WriteLine($"Сотрудник {FirstName} {SecondName} занимает должность {Post} с зарплатой {actual} (оклад {FixedPay} - {TaxAmount} налогов)");
            }
            else
            {
                Console.WriteLine("нет такой должности");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Для получения справки введите \n имя сотрудника: ");
            string name = Console.ReadLine();
            Console.Write(" фамилию сотрудника: ");
            string secondname = Console.ReadLine();
            Console.Write(" должность: ");
            string post = Console.ReadLine();

            Employee employee1 = new Employee(name, secondname, post);
            Console.Read();
        }
    }
}
    
