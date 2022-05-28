﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class IsMatchUnitTest
{
    private readonly Solution _solution;

    public IsMatchUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("aa", "a", false)]
    [InlineData("aa", "a*", true)]
    [InlineData("ab", ".*", true)]
    public void MultipleDataTest(string s, string p, bool expected)
    {
        
        bool actual = _solution.IsMatch(s, p);
        Assert.Equal(expected, actual);
    }
}