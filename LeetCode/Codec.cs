// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCode.DataStructure;

namespace LeetCode;

public class Codec
{
    /// <summary>
    /// Encode a tree to single string.
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public string Serialize(TreeNode root)
    {
        IList<int> list = new List<int>();
        PostOrder(root, list);
        return string.Join(",", list);
    }
    public TreeNode Deserialize(string data)
    {
        if (data.Length == 0)
        {
            return null;
        }
        var nums = data.Split(',');
        var stack = new Stack<int>();
        foreach (var num in nums)
        {
            stack.Push(int.Parse(num));
        }
        return Build(int.MinValue, int.MaxValue, stack);
    }

    private void PostOrder(TreeNode root, IList<int> list)
    {
        if (root is null)
        {
            return;
        }
        PostOrder(root.Left, list);
        PostOrder(root.Right, list);
        list.Add(root.Val);
    }

    private TreeNode Build(int lower, int upper, Stack<int> stack)
    {
        if (stack.Count == 0 || stack.Peek() < lower || stack.Peek() > upper)
        {
            return null;
        }
        var val = stack.Pop();
        var root = new TreeNode(val)
        {
            Right = Build(val, upper, stack),
            Left = Build(lower, val, stack)
        };
        return root;
    }
}
