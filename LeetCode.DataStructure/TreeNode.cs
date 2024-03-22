// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LeetCode.DataStructure;

/// <summary>
/// Definition for a binary tree node.
/// </summary>
public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
{
    public int Val { get; set; } = val;
    public TreeNode Left { get; set; } = left;
    public TreeNode Right { get; set; } = right;

    public TreeNode(int x) : this(x, null)
    {
    }
}


public class TreeNodeComparer : IEqualityComparer<TreeNode>
{
    public bool Equals(TreeNode x, TreeNode y)
    {
        if (x is null && y is null)
        {
            return true;
        }
        else if (x is null || y is null)
        {
            return false;
        }
        var q1 = new Queue<TreeNode>();
        var q2 = new Queue<TreeNode>();
        q1.Enqueue(x);
        q2.Enqueue(y);
        while (q1.Count != 0 && q2.Count != 0)
        {
            var node1 = q1.Dequeue();
            var node2 = q2.Dequeue();
            if (node1.Val != node2.Val)
            {
                return false;
            }
            TreeNode left1 = node1.Left, right1 = node1.Right, left2 = node2.Left, right2 = node2.Right;
            if ((left1 is null ^ left2 is null) || (right1 is null ^ right2 is null))
            {
                return false;
            }
            if (left1 is not null)
            {
                q1.Enqueue(left1);
            }
            if (right1 is not null)
            {
                q1.Enqueue(right1);
            }
            if (left2 is not null)
            {
                q2.Enqueue(left2);
            }
            if (right2 is not null)
            {
                q2.Enqueue(right2);
            }
        }
        return q1.Count == 0 && q2.Count == 0;
    }

    public int GetHashCode([DisallowNull] TreeNode obj)
    {
        throw new System.NotImplementedException();
    }
}