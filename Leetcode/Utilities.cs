// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using System.Text;

using Leetcode.DataStructure;

namespace Leetcode;

public static class Utilities
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

    public static string ConvertMatrixToString(int[][] matrix)
    {
        StringBuilder sb = new StringBuilder();
        int n = matrix.Length;
        sb.Append('[');
        for (int i = 0; i < n; i++)
        {
            if (i != 0)
            {
                sb.Append(' ');
            }
            sb.Append('[');
            sb.Append(string.Join(',', matrix[i]));
            sb.Append(']');
            if (i != n - 1)
            {
                sb.Append('\n');
            }
        }
        sb.Append(']');
        return sb.ToString();
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

    public static TreeNode CreateTreeNodeIteratively(List<int?> nums)
    {
        if (nums[0] == null)
        {
            return null;
        }
        TreeNode root = new TreeNode(nums[0].Value);
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int cursor = 1;
        int n = nums.Count;
        while (cursor < nums.Count)
        {
            TreeNode node = queue.Dequeue();

            if (cursor > n - 1 || nums[cursor] == null)
            {
                node.left = null;
            }
            else
            {
                TreeNode left = new TreeNode(nums[cursor].Value);
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
                TreeNode right = new TreeNode(nums[cursor + 1].Value);
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

    public static TreeNode CreateTreeNodeRecursively(List<int?> nums)
    {
        TreeNode CreateNode(List<int?> data, int index)
        {
            if (index >= data.Count || data[index] is null)
            {
                return null;
            }
            TreeNode root = new TreeNode(data[index].Value);
            root.left = CreateNode(nums, 2 * index + 1);
            root.right = CreateNode(nums, 2 * index + 2);
            return root;
        }
        return CreateNode(nums, 0);
    }

    public static TreeNode CreateTreeNodeWithDFS(List<int?> nums)
    {
        TreeNode DFS(List<int?> dataList)
        {
            if (!dataList.Any())
            {
                return null;
            }
            if (dataList[0] is null)
            {
                dataList.RemoveAt(0);
                return null;
            }
            TreeNode root = new TreeNode(dataList[0].Value);
            dataList.RemoveAt(0);
            root.left = DFS(dataList);
            root.right = DFS(dataList);
            return root;
        }
        return DFS(nums);
    }
}
