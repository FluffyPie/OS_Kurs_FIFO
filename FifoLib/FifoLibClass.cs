using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifoLib
{
    public static class FifoLibClass
    {
        static public int FifoFunc(out int Droped, Queue<int> Queue, out int Added, int Dequeued)
        {
            Droped = Queue.Dequeue();
            Added = Dequeued;
            Queue.Enqueue(Dequeued);
            return Dequeued;
        }
    }

}
