// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace Leetcodecsharp.DataStructure
{
    /// <summary>
    /// Definition for a Node.
    /// </summary>
    public class Node
    {
        public int val;
        public IList<Node> children;
        public Node()
        {

        }
        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }


    /// <summary>
    /// Definition for a binary tree node.
    /// </summary>
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) => val = x;
    }

}
