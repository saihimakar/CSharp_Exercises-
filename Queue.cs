using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace QueueWithTwoStacks
{
    class Program
    {
        private ArrayList pqueue;

        public void QueueWithTwoStacks()
        {
          pqueue = new ArrayList();
        }

        public void EnQueue(object item)
        {
            pqueue.Add(item);

        }

        public void DeQueue()
        {
            pqueue.RemoveAt(0);
        }

        public object Peek()
        {
            return pqueue[0];

        }

        public void ClearQueue()
        {
            pqueue.Clear();
        }

        public int Count()
        {
            return pqueue.Count;
        }

        static void Main(string[] args)
        {

        }
    }
}
