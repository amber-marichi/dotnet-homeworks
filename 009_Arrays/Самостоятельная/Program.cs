using System;

namespace Самостоятельная
{
    class Program
    {
      public static int AddTask(string[] tasks, int lastTaskIndex, string newTask)
        {
            tasks[lastTaskIndex] = newTask; ++lastTaskIndex;
            return lastTaskIndex;
        }
            static string[] MakeArray(string[] tasks)
        {
            string[] newTasks = new string[tasks.Length * 2];
            for (int i = 0; i < tasks.Length; i++)
            {
                newTasks[i] = tasks[i];
            }
            return newTasks;
        }

        static void Main(string[] args)
        {
            string[] tasks = new string[6];
            
            int lastTaskIdx = 0;
            for (int i = 0; i < 5; i++)
            {
                lastTaskIdx = AddTask(tasks, lastTaskIdx, "do something" + i);
            }

            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("Существующий список заданий: ");

                for (int i = 0; i < tasks.Length; i++)
                {
                    Console.WriteLine(tasks[i]);
                }
                Console.Write("введите новое задание: ");

                string newTask = Console.ReadLine();

                if (lastTaskIdx < tasks.Length)
                {
                    lastTaskIdx = AddTask(tasks, lastTaskIdx, newTask);
                }
                else
                {
                    tasks = MakeArray(tasks);
                    lastTaskIdx = AddTask(tasks, lastTaskIdx, newTask);
                }
            }
        }
    }
}
