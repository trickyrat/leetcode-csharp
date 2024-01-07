// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Text;

using LeetCodecsharp.DataStructure;

namespace LeetCodecsharp;

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
            dummy.next = new ListNode(item);
            dummy = dummy.next;
        }
        return head.next;
    }

    public static List<int> ConvertListNodeToList(ListNode head)
    {
        var res = new List<int>();
        while (head is not null)
        {
            res.Add(head.val);
            head = head.next;
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

    public static TreeNode CreateTreeNode(List<int?> nums)
    {
        if (nums[0] == null)
        {
            return null;
        }
        var root = new TreeNode(nums[0].Value);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var cursor = 1;
        var n = nums.Count;
        while (cursor < nums.Count)
        {
            var node = queue.Dequeue();

            if (cursor > n - 1 || nums[cursor] == null)
            {
                node.left = null;
            }
            else
            {
                var left = new TreeNode(nums[cursor].Value);
                if (node is not null)
                {
                    node.left = left;
                }
                queue.Enqueue(left);
            }
            if (cursor + 1 > n - 1 || nums[cursor + 1] == null)
            {
                node.right = null;
            }
            else
            {
                var right = new TreeNode(nums[cursor + 1].Value);
                if (node is not null)
                {
                    node.right = right;
                }
                queue.Enqueue(right);
            }
            cursor += 2;
        }

        return root;
    }
}
