// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace Leetcodecsharp.DataStructure;

/// <summary>
/// Definition for singly-linked list.
/// </summary>
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int x) => val = x;
    public ListNode(int x, ListNode next)
    {
        val = x;
        this.next = next;
    }
}
