﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace LeetCodecsharp;
public class StockSpanner
{
    public int Index
    {
        get; private set;
    }
    public Stack<(int day, int price)> Stack
    {
        get; set;
    }
    public StockSpanner()
    {
        Stack = new Stack<(int day, int price)>();
        Stack.Push((-1, int.MaxValue));
        Index = -1;
    }

    public int Next(int price)
    {
        Index++;
        while (price >= Stack.Peek().price)
        {
            Stack.Pop();
        }
        var res = Index - Stack.Peek().day;
        Stack.Push((Index, price));
        return res;
    }
}
