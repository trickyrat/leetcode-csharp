using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcodecsharp
{
    public class MinStack
    {
        public Stack<int> Min { get; protected set; }
        public Stack<int> X { get; protected set; }

        public MinStack()
        {
            Min = new Stack<int>();
            X = new Stack<int>();
            Min.Push(int.MaxValue);
        }

        public void Push(int val)
        {
            X.Push(val);
            Min.Push(Math.Min(Min.Peek(), val));
        }

        public void Pop()
        {
            X.Pop();
            Min.Pop();
        }

        public int Top()
        {
            return X.Peek();
        }

        public int GetMin()
        {
            return Min.Peek();
        }
    }
}
