using System;
using System.Runtime.InteropServices;

namespace Задание3
{
    class MyMatrix
    {
        public int ySize = 0;
        public int xSize = 0;
        int[,] matrix;
        public MyMatrix(int valueX, int valueY)
        {

            if (valueX >= 0 && valueY >= 0)
            {
                ySize = valueY;
                xSize = valueX;
            }
            else
            {
                Console.WriteLine("недопустимое значение");
            }
           
            matrix = new int[ySize, xSize];
            int number = 10;
            for (int y = 0; y < ySize; y++)
            {
                for (int x = 0; x < xSize; x++)
                {
                    matrix[y, x] = number; number++;
                }
            }
        }
        public void ShowWhole()
        {
            for (int y = 0; y < ySize; y++)
            {
                for (int x = 0; x < xSize; x++)
                {
                    Console.Write(matrix[y, x] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ShowPart(int xStart, int yStart, int partXSize, int partYSize )
        {
            if(xStart <= 0 || yStart <= 0 || partXSize > xSize || partYSize > ySize)
            {
                Console.WriteLine("значение находится за пределами массива");
                return;
            }

            if (xStart >= partXSize || yStart >= partYSize)
            {
                Console.WriteLine("неправильно введены значения");
                return;
            }

            for (int y = (yStart - 1); y < partYSize; y++)
            {
                for (int x = (xStart - 1); x < partXSize; x++)
                {
                    Console.Write(matrix[y, x] + " ");
                }
                Console.WriteLine();
            }
        }

        public int this[int index, int index1]
        {
            get
            {
                if (index <= ySize && index1 <= xSize)
                return matrix[index, index1];
                
                Console.WriteLine("обращение за пределы массива");
                return 0;
            }
            set
            {
                if (index <= ySize && index1 <= xSize)
                    matrix[index, index1] = value;
            }
        }
 
    }

    class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new MyMatrix(9, 10);  
            matrix1.ShowWhole(); // начальный массив целиком
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(matrix1[2, 2]); // отображение отдельный элементов
            Console.WriteLine(matrix1[17, 3]);
            Console.WriteLine(matrix1[5, 1]);
            Console.WriteLine(new string('-', 30));

            matrix1[3, 1] = 00;  // несение изменений в массив по индексам
            matrix1[7, 8] = 00;
            matrix1.ShowWhole();  // отображение массива с изменениями
            Console.WriteLine(new string('-', 30));

            var matrix2 = new MyMatrix(3, 4);
            matrix2.ShowWhole(); // постороение нового массива уменьшенного размера
            Console.WriteLine(new string('-', 30));

            matrix1.ShowPart(4, 2, 6, 5);  // часть массива по координатам первой и последней точек
            Console.WriteLine(new string('-', 30));

            matrix1.ShowPart(3, 5, 7, 7); // еще часть массива

            Console.Read();
        }
    }
}
