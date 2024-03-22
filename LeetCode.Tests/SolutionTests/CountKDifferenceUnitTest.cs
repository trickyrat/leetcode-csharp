// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class CountKDifferenceUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 2, 2, 1 }, 1, 4
        ];

        yield return
        [
            new[] { 1, 3 }, 3, 0
        ];

        yield return
        [
            new[] { 3, 2, 1, 5, 4 }, 2, 3
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int k, int expected)
    {
        var actual = Solution.CountKDifference(nums, k);
        Assert.Equal(expected, actual);
    }
}