﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;
public class GenerateTheStringUnitTest
{
    private readonly Solution _solution;

    public GenerateTheStringUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(4, "aaab")]
    [InlineData(2, "ab")]
    [InlineData(3, "aaa")]
    public void MultipleDataTest(int input, string expected)
    {
        var actual = _solution.GenerateTheString(input);
        Assert.Equal(expected, actual);
    }
}
