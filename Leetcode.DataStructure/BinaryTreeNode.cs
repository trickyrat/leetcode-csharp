// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace Leetcodecsharp.DataStructure;

public class BinaryTreeNode
{
    public int val;
    public BinaryTreeNode left;
    public BinaryTreeNode right;
    public BinaryTreeNode next;

    public BinaryTreeNode() { }

    public BinaryTreeNode(int _val)
    {
        val = _val;
    }

    public BinaryTreeNode(int _val, BinaryTreeNode _left, BinaryTreeNode _right, BinaryTreeNode _next)
    {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }

}

