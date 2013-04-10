using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DiningPhilosophersProblem
{
    enum DinerState { Eat, Get, Pon }

    class Fork                    //       Using an object for locking purposes
    {                             //                         instead of an int.
        public int holder = -1;   //    initialized without a holder (on table)
    }

    class Diner
    {
        private static int instanceCount;
        public Fork left;
        public Fork right;
        public int id;
        public DinerState state = new DinerState();
        const int maxWaitMs = 100;
        public bool end = false;

        public Diner()
        {
            id = instanceCount++;
            left = DiningPhilosphers.forks[id];
            right = DiningPhilosphers.forks[(id + 1) % DiningPhilosphers.dinerCount];
            state = DinerState.Get;
            Thread thread = new Thread(new ThreadStart(doStuff));
            thread.Start();             // start instance's thread to doStuff()
        }

        public void doStuff()
        {
            do
            {
                if (state == DinerState.Get)
                {
                    bool lockedL = false;
                    Monitor.TryEnter(left, ref lockedL);      //     try lock L

                    if (lockedL)                              //  got left fork
                    {
                        left.holder = id;           //  left fork holder = this
                        bool lockedR = false;
                        Monitor.TryEnter(right, ref lockedR);     // try lock R

                        if (lockedR)                //    lock R succeeded too.
                        {                           //           got both forks
                            right.holder = id;      //      list this as holder
                            state = DinerState.Eat; //                     Eat.
                            Thread.Sleep(DiningPhilosphers.rand.Next(maxWaitMs));
                            right.holder = -1;      // no right fork holder now
                            Monitor.Exit(right);    //                 unlock R
                            left.holder = -1;       //  no left fork holder now
                            Monitor.Exit(left);     //                 unlock L
                            state = DinerState.Pon; //                  Ponder.
                            Thread.Sleep(DiningPhilosphers.rand.Next(maxWaitMs));
                        }
                        else       // got left, but not right, so put left down
                        {
                            left.holder = -1;       //            no holder now
                            System.Threading.Monitor.Exit(left);    // unlock L
                            Thread.Sleep(DiningPhilosphers.rand.Next(maxWaitMs));
                        }
                    }
                    else           //                 could not get either fork
                    {              //                                wait a bit
                        Thread.Sleep(DiningPhilosphers.rand.Next(maxWaitMs));
                    }
                }
                else               //                   state == DinerState.Pon
                {                  //      done pondering, go back to get forks
                    state = DinerState.Get;         //      trying to get forks
                }
            } while (!end);
        }
    }

    class DiningPhilosphers
    {
        public const int dinerCount = 5;
        const int runSeconds = 60;
        public static List<Diner> diners = new List<Diner>();
        public static List<Fork> forks = new List<Fork>();
        public static Random rand = new Random();

        static void Main(string[] args)
        {
            for (int i = 0; i < dinerCount; i++) forks.Add(new Fork());
            for (int i = 0; i < dinerCount; i++) diners.Add(new Diner());
            DateTime endTime = DateTime.Now + new TimeSpan(0, 0, runSeconds);
            Console.Write("|");                               //   write header
            foreach (Diner d in diners) Console.Write("D " + d.id + "|");
            Console.Write("    |");
            for (int i = 0; i < dinerCount; i++) Console.Write("F" + i + "|");
            Console.WriteLine();

            do
            {                                                 // display status
                Console.Write("|");
                foreach (Diner d in diners) Console.Write(d.state + "|");
                Console.Write("    |");
                foreach (Fork f in forks) Console.Write(
                    (f.holder < 0 ? "  " : "D" + f.holder) + "|");
                Console.WriteLine();
                Thread.Sleep(1000);                           //   milliseconds
            } while (DateTime.Now < endTime);

            foreach (Diner d in diners) d.end = true;         // signal to quit
        }
    }
}
