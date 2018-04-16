using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class ImplementStack
    {
        private Stack<int> data;
        private Stack<int> mins;
        

        public ImplementStack()
        {
            data = new Stack<int>();
            mins = new Stack<int>();
            data.Push(-1);
            mins.Push(int.MaxValue);



        }
        public void Push(int x)
        {
            data.Push(x);
            mins.Push(Math.Min(x, mins.Peek()));  // pushes the smallest number the

        }
        public void Pop()
        {
            if (data.Count() > 1)
            {

                data.Pop();
                mins.Pop();
            }


        }
        public int Top()
        {
            return data.Peek();
        }
        public int GetMin()
        {
            return mins.Peek();
        }
    }
}
