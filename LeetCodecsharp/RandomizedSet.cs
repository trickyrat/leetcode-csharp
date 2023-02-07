// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodecsharp;

public class RandomizedSet
{
    protected List<int> Nums { get; set; }
    protected Dictionary<int, int> Indices { get; set; }

    protected Random Random { get; set; }

    public RandomizedSet()
    {
        Nums = new List<int>();
        Indices = new Dictionary<int, int>();
        Random = new Random();
    }

    public bool Insert(int val)
    {
        if (Indices.ContainsKey(val))
        {
            return false;
        }
        Indices.Add(val, Nums.Count);
        Nums.Add(val);
        return true;
    }

    public bool Remove(int val)
    {
        if (!Indices.ContainsKey(val))
        {
            return false;
        }

        int index = Indices[val];
        int last = Nums.Last();
        Nums[index] = last;
        Indices[last] = index;
        Nums.RemoveAt(Nums.Count - 1);
        Indices.Remove(val);
        return true;
    }

    public int GetRandom()
    {
        return Nums[Random.Next(Nums.Count)];
    }

}
