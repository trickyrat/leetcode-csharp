// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class TotalFruitUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 2, 1 }, 3
        ];
        yield return
        [
            new[] { 0, 1, 2, 2 }, 3
        ];
        yield return
        [
            new[] { 1, 2, 3, 2, 2 }, 4
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] fruits, int expected)
    {
        var actual = Solution.TotalFruit(fruits);
        Assert.Equal(expected, actual);
    }
}