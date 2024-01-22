// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MinimumDifferenceUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 90 }, 1, 0
        ];

        yield return
        [
            new[] { 9, 4, 1, 7 }, 2, 2
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] nums, int k, int expected)
    {
        var actual = Solution.MinimumDifference(nums, k);
        Assert.Equal(expected, actual);
    }
}