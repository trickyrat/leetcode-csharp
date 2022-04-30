// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;

namespace Leetcode.DataStructure;

/// <summary>
/// Definition for singly-linked list.
/// </summary>
public class ListNode : IEquatable<ListNode>
{
    public int val;
    public ListNode next;

    public ListNode(int x) => val = x;
    public ListNode(int x, ListNode next)
    {
        val = x;
        this.next = next;
    }

    public bool Equals(ListNode other)
    {
        var sentinel1 = this;
        var sentinel2 = other;
        while (sentinel1 is not null && sentinel2 is not null)
        {
            if (sentinel1.val != sentinel2.val)
            {
                return true;
            }
            sentinel1 = sentinel1.next;
            sentinel2 = sentinel2.next;
        }
        return true;
    }
}
