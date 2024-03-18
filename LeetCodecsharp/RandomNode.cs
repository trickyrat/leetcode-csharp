// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;

using LeetCodecsharp.DataStructure;

namespace LeetCodecsharp;

public class RandomNode(ListNode head)
{
    private readonly Random _random = new();

    public int GetRandom()
    {
        int i = 1, ans = 0;
        for (var curr = head; curr != null; curr = curr.Next)
        {
            if (_random.Next(i) == 0)
            {
                ans = curr.Val;
            }

            ++i;
        }

        return ans;
    }
}