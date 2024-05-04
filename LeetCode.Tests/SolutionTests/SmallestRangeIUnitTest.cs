﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class SmallestRangeIUnitTest
{
    [Theory]
    [InlineData(new int[] { 1 }, 0, 0)]
    [InlineData(new int[] { 0, 10 }, 2, 6)]
    [InlineData(new int[] { 1, 3, 6 }, 3, 0)]
    public void Test(int[] nums, int k, int expected)
    {
        var actual = Solution.SmallestRangeI(nums, k);
        Assert.Equal(expected, actual);
    }
}