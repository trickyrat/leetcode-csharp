// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace LeetCodecsharp;

public class KthLargest
{
    private PriorityQueue<int, int> Pq { get; }

    private int K { get; }

    public KthLargest(int k, int[] nums)
    {
        Pq = new PriorityQueue<int, int>();
        K = k;
        foreach (var num in nums)
        {
            Add(num);
        }
    }

    public int Add(int val)
    {
        Pq.Enqueue(val, val);
        if (Pq.Count > K)
        {
            Pq.Dequeue();
        }

        return Pq.Peek();
    }
}