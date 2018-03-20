using System;
using System.Threading;

namespace WaitHandles1 {

    class BasicWaitHandle {

        private static EventWaitHandle wh = new AutoResetEvent(false);

        static void Main() {
            new Thread(Waiter).Start();
            Thread.Sleep(1000);
            wh.Set();
        }
        static void Waiter() {
            Console.WriteLine("Waiting...");
            wh.WaitOne();
            Console.WriteLine("Notified");
        }
    }
}
