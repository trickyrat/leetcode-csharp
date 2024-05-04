﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class SearchInRotatedSortedArrayUnitTest
{
    [Theory]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
    [InlineData(new int[] { 1 }, 0, -1)]
    public void MultipleDataTest(int[] nums, int target, int expected)
    {
        var actual = Solution.Search(nums, target);
        Assert.Equal(expected, actual);
    }

}