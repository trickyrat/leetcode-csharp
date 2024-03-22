// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class MaxAreaUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49
        ];
        yield return
        [
            new[] { 1, 1 }, 1
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] height, int expected)
    {
        var actual = Solution.MaxArea(height);
        Assert.Equal(expected, actual);
    }
}