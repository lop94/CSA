using System.Threading; 

namespace Counter {

    class Counter {

        private int count = 0;

        public int NextNumber() {
            Monitor.Enter(this);
            try
            {
                count++;
            }
            finally
            {
                Monitor.Exit(this); 
            } 
            return count;
        }
    }
}
