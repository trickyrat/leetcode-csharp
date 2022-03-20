// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace Leetcode.DataStructure;

public class BinaryTreeNode
{
    public int Val { get; set; }
    public BinaryTreeNode Left { get; set; }
    public BinaryTreeNode Right { get; set; }
    public BinaryTreeNode Next { get; set; }

    public BinaryTreeNode() { }

    public BinaryTreeNode(int val)
    {
        Val = val;
    }

    public BinaryTreeNode(int val, BinaryTreeNode left, BinaryTreeNode right, BinaryTreeNode next)
    {
        Val = val;
        Left = left;
        Right = right;
        Next = next;
    }

}

