﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class SortedSquaresUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { -4, -1, 0, 3, 10 }, new[] { 0, 1, 9, 16, 100 }
        ];
        yield return
        [
            new[] { 0, 3, 4, 6, 10 }, new[] { 0, 9, 16, 36, 100 }
        ];
        yield return
        [
            new[] { -10, -6, -5, -4, -3 }, new[] { 9, 16, 25, 36, 100 }
        ];
        yield return
        [
            new[] { -7, -3, 2, 3, 11 }, new[] { 4, 9, 9, 49, 121 }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test_Should_Ok(int[] nums, int[] expected)
    {
        var actual = Solution.SortedSquares(nums);
        Assert.Equal(expected, actual);
    }
}