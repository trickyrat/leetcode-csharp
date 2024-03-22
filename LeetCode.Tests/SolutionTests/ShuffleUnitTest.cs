// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class ShuffleUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 2, 5, 1, 3, 4, 7 }, 3, new[] { 2, 3, 5, 4, 1, 7 }
        ];
        yield return
        [
            new[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4, new[] { 1, 4, 2, 3, 3, 2, 4, 1 }
        ];
        yield return
        [
            new[] { 1, 1, 2, 2 }, 2, new[] { 1, 2, 1, 2 }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] nums, int n, int[] expected)
    {
        var actual = Solution.Shuffle(nums, n);
        Assert.Equal(expected, actual);
    }
}