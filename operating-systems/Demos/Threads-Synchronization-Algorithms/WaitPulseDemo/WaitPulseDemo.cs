using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WaitPulseDemo
{
    public class WaitPulse
    {
        private object mSync;
        private string mName;

        public WaitPulse(object aSync, string aName)
        {
            mSync = aSync;
            mName = aName;
        }

        public void DoJob()
        {
            lock (mSync)
            {
                Monitor.Pulse(mSync);
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("{0}: Pulse", mName);
                    Monitor.Pulse(mSync);

                    Console.WriteLine("{1}: Wait", mName);
                    Monitor.Wait(mSync);

                    Console.WriteLine("{2} WokeUp", mName);
                    Thread.Sleep(1000);
                }
            }
        }
    }

    class WaitPulseDemo
    {
        static void Main(string[] args)
        {
        }
    }
}
