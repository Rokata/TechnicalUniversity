using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AsyncCalls
{
    class AsyncCall
    {
        public delegate int MyDelegate(int a, int b);

        public static int Sum(int a, int b)
        {
            Thread.Sleep(3000);
            return a + b;
        }

        static void Main(string[] args)
        {
            MyDelegate asyncCall = new MyDelegate(Sum);
            Console.WriteLine("Starting method async.");

            IAsyncResult status = asyncCall.BeginInvoke(5, 6, null, null);

            Console.WriteLine("Async method is working");
            Console.WriteLine("Calling EndInvoke()");

            int result = asyncCall.EndInvoke(status);

            Console.WriteLine("EndInvoke() returned");
            Console.WriteLine("Result={0}", result);

        }
    }
}
