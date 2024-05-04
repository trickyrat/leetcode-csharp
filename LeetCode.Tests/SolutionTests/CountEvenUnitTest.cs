﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class CountEvenUnitTest
{
    [Theory]
    [InlineData(4, 2)]
    [InlineData(30, 14)]
    public void Test(int num, int expected)
    {
        var actual = Solution.CountEven(num);
        Assert.Equal(expected, actual);
    }
}