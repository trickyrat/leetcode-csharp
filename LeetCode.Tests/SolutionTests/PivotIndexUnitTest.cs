﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class PivotIndexUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 7, 3, 6, 5, 6 }, 3
        ];
        yield return
        [
            new[] { 1, 2, 3 }, -1
        ];
        yield return
        [
            new[] { 2, 1, -1 }, 0
        ];
    }
    
    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int expect)
    {

        var actual = Solution.PivotIndex(nums);
        Assert.Equal(expect, actual);
    }
}