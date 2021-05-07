using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcodecsharp
{
    public class MyStack
    {

        private Queue<int> queue;
        public MyStack()
        {
            queue = new Queue<int>();
        }

        public void Push(int x)
        {
            int n = queue.Count;
            queue.Enqueue(x);
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }

        public int Pop()
        {
            return queue.Dequeue();
        }

        public int Top()
        {
            return queue.Peek();
        }

        public bool Empty()
        {
            return queue.Count == 0;
        }
    }
}
