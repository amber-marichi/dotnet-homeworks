using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Variables!");

            const double Pi = 3.14159265;
            {
                Console.WriteLine("Задание 1");
                //Выполните и рассчитайте результат следующих операций для переменных:
                
                int x = 10, y = 12, z = 3;
                
                int result = x += y - x++ * z;

                int result2 = z = --x - y * 5;

                int result3 = y /= x + 5 % z;

                int result4 = z = x++ + y * 5;

                int result5 = x = y - x++ * z;

                Console.WriteLine(result);
                Console.WriteLine(result2);
                Console.WriteLine(result3);
                Console.WriteLine(result4);
                Console.WriteLine(result5); 
                Console.ReadLine();
            }
            {
                Console.WriteLine("Задание 2");
                //Вычислите среднее арифметическое трех целочисленных значений и выведите его на экран. 

                int a = 4, b = 9, c = 12;

                double average = (double)(a + b + c) / 3; 

                Console.WriteLine(average);
                Console.ReadLine();
            }
            {
                Console.WriteLine("Задание 3");
                //Создайте константу с именем -pi (число π «пи»), создайте переменную радиус с именем – r.
                //Используя формулу πR2, вычислите площадь круга и выведите результат на экран.

                int r = 8;

                double S = Pi * Math.Pow(r, 2);

                Console.WriteLine($"Площадь круга равна {S} cm2.");
                Console.ReadLine();
            }
            {
                Console.WriteLine("Задание 4");
                //Напишите программу расчета объема – V и площади поверхности – S цилиндра. 
                //Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πR2h
                //Площадь S поверхности цилиндра вычисляется по формуле: S = 2πRh +2πR2 = 2πR(R + h)

                byte r = 6;
                byte h = 14;

                double V = pi * Math.Pow(r, 2) * h;

                Console.WriteLine($"Объем цилиндра равен {V} cm3.");

                double S = 2 * pi * r * (r + h);

                Console.WriteLine("Площадь поверхности цилиндра равна " + S + " cm2.");
                Console.Read();
            }
        }
    }
}
