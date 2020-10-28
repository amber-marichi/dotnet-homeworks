using System;

namespace Задание3
{
    class Player : IPlayable, IRecordable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("выполняется воспроизведение ...");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("воспроизведение на паузе");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("воспроизведение остановлено");
        }
        void IRecordable.Record()
        {
            Console.WriteLine("выполняется запись ...");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("запись на паузе");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("запись остановлена");
        }
    }
}
