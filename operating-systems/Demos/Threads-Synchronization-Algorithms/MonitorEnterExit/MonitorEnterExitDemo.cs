using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MonitorEnterExit
{
    public class MonitorEnterExit
    {
        private int mCounter;
        public void CriticalSection()
        {
            Monitor.Enter(this);
            mCounter = 0;
            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write(++mCounter);
                    Thread.Sleep(1000);
                }
            }
            finally
            {
                Monitor.Exit(this);
            }
        }
    }

    class MonitorEnterExitDemo
    {
        static void Main(string[] args)
        {
            MonitorEnterExit mee = new MonitorEnterExit();
            Thread thread1 = new Thread(new
              ThreadStart(mee.CriticalSection));
            thread1.Start();
            Thread thread2 = new Thread(new
              ThreadStart(mee.CriticalSection));
            thread2.Start();

        }
    }
}
