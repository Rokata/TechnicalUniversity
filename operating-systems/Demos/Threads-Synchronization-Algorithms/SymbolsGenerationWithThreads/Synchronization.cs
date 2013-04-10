using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SymbolsGenerationWithThreads
{
    public class CharGenerator
    {
        private static char[] chars = { '!', '@', '#', '$', '%', '^', '&', '*' };
        public char ch;
        public bool end = false;
        private Mutex mutex = new Mutex();

        public void GenerateChar()
        {
            do
            {
                for (int i = 0; i < chars.Length; Interlocked.Increment(ref i))
                {
                    mutex.WaitOne();
                    ch = chars[i];
                    mutex.ReleaseMutex();
                }

            }
            while (!end);
        }
    }

    class Synchronization
    {
        static void Main()
        {
            CharGenerator g1 = new CharGenerator();
            CharGenerator g2 = new CharGenerator();
            CharGenerator g3 = new CharGenerator();
            Thread t1 = new Thread(new ThreadStart(g1.GenerateChar));
            Thread t2 = new Thread(new ThreadStart(g2.GenerateChar));
            Thread t3 = new Thread(new ThreadStart(g3.GenerateChar));
            t1.Start();
            t2.Start();
            t3.Start();

            string input = "";

            do
            {

                Console.WriteLine("Enter \"try\" when you're ready, \"exit\" to escape");
                input = Console.ReadLine();

                if (input == "try" || input == "t")
                {
                    t1.Suspend();
                    t2.Suspend();
                    t3.Suspend();
                    if (g1.ch == g2.ch && g2.ch == g3.ch)
                    {
                        Console.WriteLine(g1.ch + " " + g2.ch + " " + g3.ch + " won");
                    }
                    else
                    {
                        Console.WriteLine(g1.ch + " " + g2.ch + " " + g3.ch + " lost");
                    }

                    t1.Resume();
                    t2.Resume();
                    t3.Resume();
                }
                Thread.Sleep(100);
            } while (input != "exit");

            g1.end = true;
            g2.end = true;
            g3.end = true;

            return;
        }
    }
}
