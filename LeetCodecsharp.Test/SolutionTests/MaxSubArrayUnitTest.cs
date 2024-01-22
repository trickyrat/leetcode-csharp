// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MaxSubArrayUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6
        ];

        yield return
        [
            new[] { 1 }, 1
        ];

        yield return
        [
            new[] { 5, 4, -1, 7, 8 }, 23
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.MaxSubArray(nums);
        Assert.Equal(expected, actual);
    }
}