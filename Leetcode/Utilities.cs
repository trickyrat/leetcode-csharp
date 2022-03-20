// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Leetcode.DataStructure;

namespace Leetcode;

public static class Utilities
{

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static ListNode CreateListNode(IEnumerable<int> data)
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

    public static List<int> ConvertListNodeToList(ListNode head)
    {
        List<int> res = new List<int>();
        while (head is not null)
        {
            res.Add(head.val);
            head = head.next;
        }
        return res;
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

    public static TreeNode CreateTreeNodeWithBFS(string data)
    {
        string[] nums = data.Split(',');
        if (nums[0] == "null")
        {
            return null;
        }
        TreeNode root = new TreeNode(Convert.ToInt32(nums[0]));
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int cursor = 1;
        while (cursor < nums.Length)
        {
            TreeNode node = queue.Dequeue();
            string leftValue = nums[cursor];
            string rightValue = nums[cursor + 1];
            if (leftValue != "null")
            {
                TreeNode left = new TreeNode(Convert.ToInt32(leftValue));
                if (node is not null)
                {
                    node.left = left;
                }
                queue.Enqueue(left);
            }
            if (rightValue != "null")
            {
                TreeNode right = new TreeNode(Convert.ToInt32(rightValue));
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

    public static TreeNode CreateTreeNodeWithBFS(List<int?> data)
    {
        if (nums[0] == "null")
        {
            return null;
        }
        TreeNode root = new TreeNode(Convert.ToInt32(nums[0]));
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int cursor = 1;
        while (cursor < nums.Length)
        {
            TreeNode node = queue.Dequeue();
            string leftValue = nums[cursor];
            string rightValue = nums[cursor + 1];
            if (leftValue != "null")
            {
                TreeNode left = new TreeNode(Convert.ToInt32(leftValue));
                if (node is not null)
                {
                    node.left = left;
                }
                queue.Enqueue(left);
            }
            if (rightValue != "null")
            {
                TreeNode right = new TreeNode(Convert.ToInt32(rightValue));
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

    public static TreeNode CreateTreeNodeWithDFS(string data)
    {
        List<string> list = data.Split(',').ToList();
        return DFS(list);
        TreeNode DFS(List<string> dataList)
        {
            if (!dataList.Any())
            {
                return null;
            }
            if (dataList[0] == "null")
            {
                dataList.RemoveAt(0);
                return null;
            }
            TreeNode root = new TreeNode(Convert.ToInt32(dataList[0]));
            dataList.RemoveAt(0);
            root.left = DFS(dataList);
            root.right = DFS(dataList);
            return root;
        }
    }
}
