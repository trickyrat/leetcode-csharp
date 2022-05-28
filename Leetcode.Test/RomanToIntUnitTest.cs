﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class RomanToIntUnittest
{
    private readonly Solution _solution;
    public RomanToIntUnittest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("IX", 9)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void MultipleDataTest(string s, int expected)
    {
        
        int actual = _solution.RomanToInt(s);
        Assert.Equal(expected, actual);
    }
}