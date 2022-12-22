// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;

using LeetCode.DataStructure;

namespace LeetCode;

public class RandomNode
{
    private readonly ListNode _head;
    private readonly Random _random;
    public RandomNode(ListNode head)
    {
        _head = head;
        _random = new Random();
    }

    public int GetRandom()
    {
        int i = 1, ans = 0;
        for (ListNode curr = _head; curr != null; curr = curr.next)
        {
            if (_random.Next(i) == 0)
            {
                ans = curr.val;
            }

            ++i;
        }

        return ans;
    }
}