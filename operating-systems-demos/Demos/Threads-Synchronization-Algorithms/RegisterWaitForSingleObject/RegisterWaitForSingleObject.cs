using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RegisterWaitForSingleObject
{
    class RegisterWaitForSingleObject
    {
        static void Main(string[] args)
        {
            AutoResetEvent ev = new AutoResetEvent(false);
            object param = "some param";
            RegisteredWaitHandle r = ThreadPool.RegisterWaitForSingleObject(ev, new WaitOrTimerCallback(WaitProc), param, 1000, 
                false);
            Console.ReadLine();
            Console.WriteLine("signaling.");
            ev.Set();
            Console.ReadLine();
            Console.WriteLine("unregister wait");
            r.Unregister(ev);
            Console.ReadLine(); 
        }

        public static void WaitProc(object param, bool timedOut)
        {
            string cause = "SIGNALED";
            if (timedOut)
                cause = "TIMED OUT";
            Console.WriteLine("WaitProc executes;cause = {0}", cause);
        }
    }
}
