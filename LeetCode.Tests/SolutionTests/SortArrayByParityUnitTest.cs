﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class SortArrayByParityUnitTest
{
    [Theory]
    [InlineData(new int[] { 3, 1, 2, 4 }, new int[] { 4, 2, 1, 3 })]
    [InlineData(new int[] { 0 }, new int[] { 0 })]
    public void MultipleDataTest(int[] nums, int[] expected)
    {
        var actual = Solution.SortArrayByParity(nums);
        Assert.Equal(expected, actual);
    }
}