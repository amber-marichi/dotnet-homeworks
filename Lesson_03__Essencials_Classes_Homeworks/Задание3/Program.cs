using System;

namespace Задание3
{
    class Vehicle
    {
        public string Place = null;
        public int Price = 0;
        public int Speed = 0;
        public int Year = 0;
        
        public Vehicle(string place, int price, int speed, int year)
        {
            Place = place; Price = price; Speed = speed; Year = year;
            Console.WriteLine("местонахождения " + Place);
            Console.WriteLine("цена " + Price);
            Console.WriteLine("скорость " + Speed);
            Console.WriteLine("год выпуска " + Year);
        }
    }

    class Car : Vehicle
    {
        public Car(string place, int price, int speed, int year) 
           : base(place, price, speed, year) {  }
    }
    class Plane : Vehicle
    {
        public int FlyHeight = 0;
        public int Passengers = 0;
        public Plane(string place, int price, int speed, int year, int flyHeight, int passengers)
          : base(place, price, speed, year)
        {
            FlyHeight = flyHeight; Passengers = passengers;
            Console.WriteLine("высота полета " + FlyHeight);
            Console.WriteLine("макс количество мест " + Passengers);
        }
    }
        class Ship : Vehicle
        {
            public int Passengers = 0;
            public string Portcode = null;
            public Ship(string place, int price, int speed, int year, int passengers, string portcode)
              : base(place, price, speed, year)
            {
                Passengers = passengers; Portcode = portcode;
                Console.WriteLine("макс количество мест " + Passengers);
                Console.WriteLine("порт приписки " + Portcode);
            }

        }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Автомобиль");
            Car car = new Car("Львов", 100000, 180, 1998);
            Console.WriteLine("Самолет");
            Plane plane = new Plane("Киев", 440000, 340, 2001, 4000, 80);
            Console.WriteLine("Лодка");
            Ship ship = new Ship("Одесса", 800000, 90, 1986, 15, "Стамбул");
            Console.ReadLine();
        }
    }
}
