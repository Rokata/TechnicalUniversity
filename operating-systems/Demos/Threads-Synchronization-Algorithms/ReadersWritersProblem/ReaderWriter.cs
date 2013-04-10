using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ReadersWritersProblem
{
    class CustomReaderWriter
    {
        private int mReaders = 0;
        private bool mIsWriting = false;
        public void Read()
        {
            lock (this)
            {
                while (mIsWriting) Monitor.Wait(this);
                mReaders++;
            }

            //...READING TAKES PLACE HERE...

            lock (this)
            {
                mReaders--;
                if (mReaders == 0) Monitor.Pulse(this);
            }
        }
        public void Write()
        {
            lock (this)
            {
                while (mReaders != 0)
                    Monitor.Wait(this);
                mIsWriting = true;
            }

            //...WRITING TAKES PLACE HERE...

            lock (this)
            {
                mIsWriting = false;
                Monitor.PulseAll(this);
            }
        }
    }


    class ReaderWriter
    {
        static void Main(string[] args)
        {

        }
    }
}
