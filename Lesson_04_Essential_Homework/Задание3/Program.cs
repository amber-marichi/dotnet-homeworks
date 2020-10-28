using System;

namespace Задание3
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();

    }
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Используйте кнопки от \"1\" до \"6\" для управления функциями плеера. Кнопка \"q\" для выхода.");
            IPlayable playerPlay = new Player();
            IRecordable playerRec = new Player();
            bool check = false;
            do
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        {
                            Console.Clear(); playerPlay.Play(); check = true;
                            break;
                        }
                    case "2":
                        {
                            Console.Clear(); playerPlay.Pause(); check = true;
                            break;
                        }
                    case "3":
                        {
                            Console.Clear(); playerPlay.Stop(); check = true;
                            break;
                        }
                    case "4":
                        {
                            Console.Clear(); playerRec.Record(); check = true;
                            break;
                        }
                    case "5":
                        {
                            Console.Clear(); playerRec.Pause(); check = true;
                            break;
                        }
                    case "6":
                        {
                            Console.Clear(); playerRec.Stop(); check = true;
                            break;
                        }
                    case "q":
                        {
                            Console.Clear(); check = false; Console.WriteLine("выход");
                            break;
                        }
                }
            } while (check == true);
        }
    }
}
