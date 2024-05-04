﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class BackspaceCompareUnitTest
{
    [Theory]
    [InlineData("ab#c", "ad#c", true)]
    [InlineData("ab##", "c#d#", true)]
    [InlineData("a##c", "#a#c", true)]
    [InlineData("a#c", "b", false)]
    public void Test(string s, string t, bool expected)
    {
        var actual = Solution.BackspaceCompare(s, t);
        Assert.Equal(expected, actual);
    }
}
