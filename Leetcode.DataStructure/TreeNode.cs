// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Leetcode.DataStructure;

/// <summary>
/// Definition for a binary tree node.
/// </summary>
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) => val = x;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
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
        Queue<TreeNode> q1 = new Queue<TreeNode>();
        Queue<TreeNode> q2 = new Queue<TreeNode>();
        q1.Enqueue(x);
        q2.Enqueue(y);
        while (q1.Count != 0 && q2.Count != 0)
        {
            TreeNode node1 = q1.Dequeue();
            TreeNode node2 = q2.Dequeue();
            if (node1.val != node2.val)
            {
                return false;
            }
            TreeNode left1 = node1.left, right1 = node1.right, left2 = node2.left, right2 = node2.right;
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