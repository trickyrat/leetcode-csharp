﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;
public class AreAlmostEqualUnitTest
{
    private readonly Solution _solution;

    public AreAlmostEqualUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData("bank", "kanb", true)]
    [InlineData("attack", "defend", false)]
    [InlineData("kelb", "kelb", true)]
    public void MultipleDataTest(string s1, string s2, bool expected)
    {
        var actual = _solution.AreAlmostEqual(s1, s2);
        Assert.Equal(expected, actual);
    }
}
