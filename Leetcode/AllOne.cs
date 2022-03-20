// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode;

public class AllOne
{
    AllOneNode Root { get; set; }
    Dictionary<string, AllOneNode> Nodes { get; set; }
    public AllOne()
    {
        Root = new AllOneNode();
        Root.Prev = Root;
        Root.Next = Root;
        Nodes = new Dictionary<string, AllOneNode>();
    }
    public void Inc(string key)
    {
        if (Nodes.ContainsKey(key))
        {
            AllOneNode curr = Nodes[key];
            AllOneNode next = curr.Next;
            if (next == Root || next.Count > curr.Count + 1)
            {
                Nodes[key] = curr.Insert(new AllOneNode(key, curr.Count + 1));
            }
            else
            {
                next.Keys.Add(key);
                Nodes[key] = next;
            }
            curr.Keys.Remove(key);
            if (curr.Keys.Count == 0)
            {
                curr.Remove();
            }
        }
        else
        {
            if (Root.Next == Root || Root.Next.Count > 1)
            {
                Nodes.Add(key, Root.Insert(new AllOneNode(key, 1)));
            }
            else
            {
                Root.Next.Keys.Add(key);
                Nodes.Add(key, Root.Next);
            }
        }
    }

    public void Dec(string key)
    {
        AllOneNode curr = Nodes[key];
        if (curr.Count == 1)
        {
            Nodes.Remove(key);
        }
        else
        {
            AllOneNode prev = curr.Prev;
            if (prev == Root || prev.Count < curr.Count - 1)
            {
                Nodes[key] = curr.Prev.Insert(new AllOneNode(key, curr.Count - 1));
            }
            else
            {
                prev.Keys.Add(key);
                Nodes[key] = prev;
            }
        }
        curr.Keys.Remove(key);
        if (curr.Keys.Count == 0)
        {
            curr.Remove();
        }
    }

    public string GetMaxKey()
    {
        if (Root.Prev == null)
        {
            return string.Empty;
        }
        string maxKey = string.Empty;
        foreach (string key in Root.Prev.Keys)
        {
            maxKey = key;
            break;
        }
        return maxKey;
    }

    public string GetMinKey()
    {
        if (Root.Next == null)
        {
            return string.Empty;
        }
        string minKey = string.Empty;
        foreach (string key in Root.Next.Keys)
        {
            minKey = key;
            break;
        }
        return minKey;
    }
}

class AllOneNode
{
    public AllOneNode Prev { get; set; }
    public AllOneNode Next { get; set; }
    public ISet<string> Keys { get; set; }
    public int Count { get; set; }

    public AllOneNode() : this(string.Empty, 0)
    {

    }

    public AllOneNode(string key, int count)
    {
        Count = count;
        Keys = new HashSet<string>();
        Keys.Add(key);
    }

    public AllOneNode Insert(AllOneNode node)
    {
        node.Prev = this;
        node.Next = Next;
        node.Prev.Next = node;
        node.Next.Prev = node;
        return node;
    }

    public void Remove()
    {
        Prev.Next = Next;
        Next.Prev = Prev;
    }
}

