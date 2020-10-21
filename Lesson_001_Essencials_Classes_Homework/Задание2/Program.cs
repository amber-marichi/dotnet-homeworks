using System;

namespace Задание2
{
    class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            if (side1 != 0 && side2 != 0)
            {
                this.side1 = side1;
                this.side2 = side2;
            }
            else
            { 
                Console.WriteLine("Внимание, одно из значений равно нулю."); 
            }
        }
        private double AreaCalculator()
        {
            double area = side1 * side2;
            return area;
        }
        private double PerimeterCalculator()
        {
            double perimeter = (side1 + side2) * 2;
            return perimeter;
        }

        public double Area()
        {
            return AreaCalculator();
        }
        public double Perimeter()
        {
            return PerimeterCalculator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину одной стороны прямоугоьника: ");
            int side1User = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину другой стороны прямоугоьника: ");
            int side2User = Int32.Parse(Console.ReadLine());

            Rectangle userRec = new Rectangle(side1User, side2User);
            double area = userRec.Area();
            double perimeter = userRec.Perimeter();
            Console.WriteLine("Площадь прямоугольника равна " + area);
            Console.WriteLine("Периметр прямоугольника равен " + perimeter);

            Console.ReadLine();
        }
    }
}
