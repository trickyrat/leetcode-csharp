// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Text;

using Leetcodecsharp.DataStructure;

namespace Leetcodecsharp;

public static class Utils
{

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static ListNode GenerateLinkedList(IEnumerable<int> data)
    {
        ListNode head = new ListNode(0);
        ListNode dummy = head;
        foreach (int item in data)
        {
            dummy.next = new ListNode(item);
            dummy = dummy.next;
        }
        return head.next;
    }

    public static string ConvertListNodeToString(ListNode head)
    {
        StringBuilder sb = new StringBuilder();
        while (head is not null)
        {
            sb.Append($"{head.val}");
            if (head.next is not null)
            {
                sb.Append("->");     
            }
            head = head.next;
        }
        return sb.ToString();
    }

    public static string ConvertMultiDimensionalArrayToString(int[][] array)
    {
        StringBuilder sb = new StringBuilder();
        int row = array.Length, col = array[0].Length;
        sb.Append('[');
        for (int r = 0; r < row; r++)
        {
            sb.Append('[');
            for (int c = 0; c < col; c++)
            {
                sb.Append(col);
                if (c != col - 1)
                {
                    sb.Append(", ");
                }
            }
            sb.Append(']');
            if (r != row - 1)
            {
                sb.Append('\n');
            }
        }
        sb.Append(']');
        return sb.ToString();
    }

    public static void Swap<T>(T[] array, int index1, int index2)
    {
        T temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    public static List<int> PreorderTraversal(TreeNode root)
    {
        List<int> res = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        while (root != null)
        {
            res.Add(root.val);
            if (root.right != null)
                stack.Push(root.right);
            root = root.left;
            if (root == null && stack.Count > 0)
            {
                root = stack.Pop();
            }
        }
        return res;
    }
}
