using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadPoolDemo
{
    class ThreadPoolDemo
    {
        public static void Task(object param)
        {
            Console.WriteLine("Starting " + param);
            Thread.Sleep(500);
            Console.WriteLine("Finished " + param);
        }

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string taskName = "Task " + i;
                ThreadPool.QueueUserWorkItem(new WaitCallback(Task), taskName);
            }
            Console.ReadLine();
        }
    }
}
