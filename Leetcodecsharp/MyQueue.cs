// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace Leetcodecsharp;
public class MyQueue
{
    private Stack<int> inStack, outStack;


    public MyQueue()
    {
        inStack = new Stack<int>();
        outStack = new Stack<int>();
    }

    private void In2Out()
    {
        while (inStack.Count != 0)
        {
            outStack.Push(inStack.Pop());
        }
    }

    public void Push(int x)
    {
        inStack.Push(x);
    }

    public int Pop()
    {
        if (outStack.Count == 0)
        {
            In2Out();
        }
        return outStack.Pop();
    }

    public int Peek()
    {
        if (outStack.Count == 0)
        {
            In2Out();
        }
        return outStack.Peek();
    }

    public bool Empty()
    {
        return inStack.Count == 0 && outStack.Count == 0;
    }
}
