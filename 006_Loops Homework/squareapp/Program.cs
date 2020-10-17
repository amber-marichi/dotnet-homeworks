using System;

namespace squareapp
{
    class Program
    {
        static int ReadNumbers(string message)
        {
            Console.WriteLine(message);
            int result;
            bool success = false;
            do
            {
                string input = Console.ReadLine();
                success = int.TryParse(input, out result);
            }
            while (!success);

            return result;
        }
        static void DrawRectangle(int height, int width, int shiftleft, int shifttop)
        {
            for (int topspaceIdx = 0; topspaceIdx < shifttop; topspaceIdx++)
            {
                Console.WriteLine();
            }

            for (int lineIdx = 0; lineIdx < height; lineIdx++)
            {
                for (int spaceIdx = 0; spaceIdx < shiftleft; spaceIdx++)
                {
                    Console.Write(" ");
                }
                    
               for (int textIdx = 0; textIdx < width; textIdx++)
               {
                    Console.Write("*");
                    //Console.WriteLine(new string("*"), width);
                }
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Let's build movable rectangle!");
            Console.WriteLine("(use [W] [A] [S] [D] to move, press [X] to exit)");
            Console.WriteLine();
            int width = ReadNumbers("give width");
            int height = ReadNumbers("give height");

            int shiftleft = 0;
            int shifttop = 0;

            Console.Clear();
            bool play = true;
            while (play)
            {
                Console.Clear(); 
                DrawRectangle(height, width, shiftleft, shifttop);
                var command = Console.ReadKey(true).KeyChar;

                switch (command)
                {
                    case 'w':
                        {
                            shifttop--; play = true;
                            break;
                        }
                    case 's':
                        {
                            shifttop++; play = true;
                            break;
                        }
                    case 'a':
                        {
                            shiftleft--; play = true;
                            break;
                        }
                    case 'd':
                        {
                            shiftleft++; play = true;
                            break;
                        }

                }
                switch (command)
                {
                    case 'x':
                        Console.Clear();
                        Console.WriteLine("thank you, goodbye");
                        play = false;
                        break;
                }

                if (play)
                {
                    DrawRectangle(height, width, shiftleft, shifttop);
                }

            }
        }
    }
}
