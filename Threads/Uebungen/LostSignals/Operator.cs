using System;
using System.Threading;

namespace LostSignals {

    class Operator {

        public const int MAXCOUNT = 4;
        private int counter = 0;
        private ISynch signal;
        private Random rnd;
        private EventWaitHandle next = new AutoResetEvent(false);

        public Operator(ISynch signal) {
            this.signal = signal;
            rnd = new Random();
        }
        private void Init() {
            lock (this) {
                counter = MAXCOUNT;
                Console.WriteLine("Es wurden " + counter + " Operationen vorbereitet...");
            }
        }
        public int Operation() {
            lock (this) {
                return rnd.Next(1000);
            }
        }
        public void Done(String id) {
            lock (this) {
                counter++;
                Console.WriteLine(counter + ". Operation wurde durch " + id + " beendet.");
                if (counter == MAXCOUNT) {
                    next.Set();
                }
            }
        }
        public void Do() {
            while (true) {
                Init();
                lock (this) {
                    for (; counter > 0; counter--) {
                        signal.Release();
                    }
                }
                next.WaitOne();
            }
        }
    }
}
