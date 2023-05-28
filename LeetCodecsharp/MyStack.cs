// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace LeetCodecsharp;

public class MyStack
{

    private Queue<int> queue;
    public MyStack()
    {
        queue = new Queue<int>();
    }

    public void Push(int x)
    {
        var n = queue.Count;
        queue.Enqueue(x);
        for (var i = 0; i < n; i++)
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
