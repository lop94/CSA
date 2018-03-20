using System;

namespace BlackHole {

    class BlackHole {

        private NotifyingQueue<String> queue = new NotifyingQueue<String>();

        public void put(String thing) {
            lock (this) {
                queue.enqueue(thing);
            }
        }
        public String get() {
            lock (this) {
                return queue.dequeue();
            }
        }
    }
}
