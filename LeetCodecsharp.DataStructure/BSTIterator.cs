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
            root = root.left;
        }
    }

    public int Next()
    {
        TreeNode tmp = stack.Pop();
        TreeNode right = tmp.right;
        while (right != null)
        {
            stack.Push(right);
            right = right.left;
        }
        return tmp.val;
    }

    public bool HasNext()
    {
        return stack.Count > 0;
    }
}

