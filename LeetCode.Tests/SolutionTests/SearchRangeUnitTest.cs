// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class SearchRangeUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 5, 7, 7, 8, 8, 10 }, 8, new[] { 3, 4 }
        ];
        yield return
        [
            new[] { 5, 7, 7, 8, 8, 10 }, 6, new[] { -1, -1 }
        ];
        yield return
        [
            Array.Empty<int>(), 0, new[] { -1, -1 }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] nums, int target, int[] expected)
    {
        var actual = Solution.SearchRange(nums, target);
        Assert.Equal(expected, actual);
    }
}