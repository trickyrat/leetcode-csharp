﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class MaximumSwapUnitTest
{
    [Theory]
    [InlineData(2736, 7236)]
    [InlineData(9973, 9973)]
    public void Test(int num, int expected)
    {
        var actual = Solution.MaximumSwap(num);
        Assert.Equal(expected, actual);
    }
}