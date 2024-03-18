// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace LeetCodecsharp.DataStructure;

public class BSTIterator
{
    private Stack<TreeNode> stack;

    public BSTIterator(TreeNode root)
    {
        stack = new Stack<TreeNode>();
        while (root != null)
        {
            stack.Push(root);
            root = root.Left;
        }
    }

    public int Next()
    {
        var tmp = stack.Pop();
        var right = tmp.Right;
        while (right != null)
        {
            stack.Push(right);
            right = right.Left;
        }
        return tmp.Val;
    }

    public bool HasNext()
    {
        return stack.Count > 0;
    }
}

