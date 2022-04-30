// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Text;

using Leetcode.DataStructure;

namespace Leetcode;

public class Codec
{
    private static readonly char spliter = ',';
    private static readonly string NN = "X";
    /// <summary>
    /// Encode a tree to single string.
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public string Serialize(TreeNode root)
    {
        StringBuilder sb = new StringBuilder();
        BuildString(root, sb);
        return sb.ToString();
    }
    private void BuildString(TreeNode node, StringBuilder sb)
    {
        if (node == null)
        {
            sb.Append(NN).Append(spliter);
        }
        else
        {
            sb.Append(node.val).Append(spliter);
            BuildString(node.left, sb);
            BuildString(node.right, sb);
        }
    }

    public TreeNode Deserialize(string data)
    {
        Queue<string> nodes = new Queue<string>();
        foreach (string item in data.Split(spliter))
        {
            nodes.Enqueue(item);
        }
        return BuildeTree(nodes);
    }
    private TreeNode BuildeTree(Queue<string> nodes)
    {
        string val = nodes.Dequeue();
        if (val.Equals(NN))
        {
            return null;
        }
        else
        {
            TreeNode node = new TreeNode(Convert.ToInt32(val)) {
                left = BuildeTree(nodes),
                right = BuildeTree(nodes)
            };
            return node;
        }
    }
}
