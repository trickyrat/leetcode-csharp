// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class SearchInsertUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 3, 5, 6 }, 5, 2
        ];
        yield return
        [
            new[] { 1, 3, 5, 6 }, 2, 1
        ];
        yield return
        [
            new[] { 1, 3, 5, 6 }, 7, 4
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int target, int expected)
    {
        var actual = Solution.SearchInsert(nums, target);
        Assert.Equal(expected, actual);
    }
}