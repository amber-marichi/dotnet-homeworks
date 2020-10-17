using System;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для начала расчета введите сумму заработной платы");
            string salary = Console.ReadLine();
            Console.WriteLine("Отлично! А теперь - выслуга лет");
            string age = Console.ReadLine();
            
            int salary1 = Convert.ToInt32(salary);
            int age1 = Convert.ToInt32(age);

                        
            if (age1 >=0 && age1 < 5)
            {
                int sum = (int)(salary1 + (salary1 * 0.1));
                Console.WriteLine("Итого вместе с премией {0}", sum);
            }
            if (age1 >= 5 && age1 < 10)
            {
                int sum = (int)(salary1 + (salary1 * 0.15));
                Console.WriteLine("Итого вместе с премией {0}", sum);
            }
            if(age1 >= 10 && age1 < 15)
            {
                double sum = (double)(salary1 + (salary1 * 0.25));
                Console.WriteLine("Итого вместе с премией {0}", sum);
            }
            if(age1 >= 15 && age1 < 20)
            {
                double sum = (double)(salary1 + (salary1 * 0.35));
                Console.WriteLine("Итого вместе с премией {0}", sum);
            }
            if(age1 >= 20 && age1 < 25)
            {
                double sum = (double)(salary1 + (salary1 * 0.45));
                Console.WriteLine("Итого вместе с премией {0}", sum);
            }
            if (age1 >= 25)
            {
                double sum = (double)(salary1 + (salary1 * 0.5));
                Console.WriteLine("Итого вместе с премией {0}", sum);
            }
            if (age1 < 0 || salary1 <= 0)
            { 
                Console.WriteLine("Проверьте введенные данные");
            }
                Console.ReadKey();
        }
    }
}
