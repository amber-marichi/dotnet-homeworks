using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace Задание4
{
    class Point
    {
        string name;
        private int x, y;

        public string Name
        {
            get { return name; }
        }

        public int Y
        {
            get { return y; }
        }

        public int X
        {
            get { return x; }
        }

        public Point(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }
    }

    class Figure
    {
        string name;
        Point point1, point2, point3, point4, point5;

        public Figure(Point p1, Point p2, Point p3)
        {
              point1 = p1;
              point2 = p2;
              point3 = p3;
              name = "треугольник";
            PerimeterCalculator();
        }
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            point1 = p1;
            point2 = p2;
            point3 = p3;
            point4 = p4;
            name = "четырехугольник";
            PerimeterCalculator();
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            point1 = p1;
            point2 = p2;
            point3 = p3;
            point4 = p4;
            point5 = p5;
            name = "пятиугольник";
            PerimeterCalculator();
        }
        public void PerimeterCalculator()
          {
              double sum, side1, side2, side3, side4, side5;

            switch (name)
            {
                case "треугольник":
                    {
                        side1 = LengthSide(point1, point2);
                        side2 = LengthSide(point2, point3);
                        side3 = LengthSide(point3, point1);
                        sum = side1 + side2 + side3;
                        Console.WriteLine($"Фигура - {name} с периметром {sum}");
                        break;
                    }
                case "четырехугольник":
                    {
                        side1 = LengthSide(point1, point2);
                        side2 = LengthSide(point2, point3);
                        side3 = LengthSide(point3, point4);
                        side4 = LengthSide(point4, point1);
                        sum = side1 + side2 + side3 + side4;
                        Console.WriteLine($"Фигура - {name} с периметром {sum}");
                        break;
                    }
                case "пятиугольник":
                    {
                        side1 = LengthSide(point1, point2);
                        side2 = LengthSide(point2, point3);
                        side3 = LengthSide(point3, point4);
                        side4 = LengthSide(point4, point5);
                        side5 = LengthSide(point5, point1);
                        sum = side1 + side2 + side3 + side4 + side5;
                        Console.WriteLine($"Фигура - {name} с периметром {sum}");
                        break;
                    }
            }
          }
          double LengthSide(Point A, Point B)
          {
            double side = Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
              return side;
          }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Point pointA = new Point("A", 2, 1);
            Point pointB = new Point("B", 5, 4);
            Point pointC = new Point("C", 4, 8);
            Point pointD = new Point("D", 3, 4);

            Figure myfigure = new Figure(pointA, pointB, pointC, pointD);
            Console.ReadKey();
        }
    }
}
