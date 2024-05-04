﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode;

public static class Util
{
    public static void Swap<T>(ref T a, ref T b)
    {
        (b, a) = (a, b);
    }

    public static void Swap<T>(T[] array, int index1, int index2)
    {
        (array[index2], array[index1]) = (array[index1], array[index2]);
    }

    public static ListNode CreateListNode(IEnumerable<int> data)
    {
        var head = new ListNode(0);
        var dummy = head;
        foreach (var item in data)
        {
            dummy.Next = new ListNode(item);
            dummy = dummy.Next;
        }

        return head.Next;
    }

    public static List<int> ConvertListNodeToList(ListNode head)
    {
        var res = new List<int>();
        while (head is not null)
        {
            res.Add(head.Val);
            head = head.Next;
        }

        return res;
    }

    public static string ConvertMatrixToString(int[][] matrix)
    {
        var sb = new StringBuilder();
        var n = matrix.Length;
        const char openSign = '[';
        const char closeSign = ']';
        sb.Append(openSign);
        for (var i = 0; i < n; i++)
        {
            if (i != 0)
            {
                sb.Append(' ');
            }

            sb.Append(openSign);
            sb.Append(string.Join(',', matrix[i]));
            sb.Append(closeSign);
            if (i != n - 1)
            {
                sb.Append('\n');
            }
        }

        sb.Append(closeSign);
        return sb.ToString();
    }

    public static List<int> PreorderTraversal(TreeNode root)
    {
        var res = new List<int>();
        var stack = new Stack<TreeNode>();
        while (root != null)
        {
            res.Add(root.Val);
            if (root.Right != null)
                stack.Push(root.Right);
            root = root.Left;
            if (root == null && stack.Count > 0)
            {
                root = stack.Pop();
            }
        }

        return res;
    }
    
    public static TreeNode CreateTreeNode(List<int?> nums)
    {
        if (nums is null || nums.Count == 0 || nums[0] is null)
        {
            return null;
        }

        var root = new TreeNode(nums[0].Value);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        var fillLeft = true;
        for (var i = 1; i < nums.Count; i++)
        {
            var node = nums[i] is not null ? new TreeNode(nums[i].Value) : null;

            if (fillLeft)
            {
                queue.Peek().Left = node;
                fillLeft = false;
            }
            else
            {
                queue.Peek().Right = node;
                fillLeft = true;
            }

            if (node is not null)
            {
                queue.Enqueue(node);
            }

            if (fillLeft) queue.Dequeue();
        }
        return root;
    }

    public static Node CreateNTree(List<int?> nums)
    {
        if (nums is null || nums.Count == 0 || nums[0] is null)
        {
            return null;
        }

        var root = new Node(nums[0].Value);
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        
        for (var i = 1; i < nums.Count; i++)
        {
            var parent = queue.Peek();
            if (nums[i].HasValue)
            {
                var child = new Node(nums[i].Value);
                parent.Children.Add(child);
                queue.Enqueue(child);
            }
            else if (!nums[i].HasValue && queue.Count < 2)
            {
                continue;
            }
            else
            {
                queue.Dequeue();
            }
        }

        return root;
    }
}