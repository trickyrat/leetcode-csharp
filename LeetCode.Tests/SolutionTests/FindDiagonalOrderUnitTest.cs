// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class FindDiagonalOrderUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[]
            {
                new[] { 1, 2, 3 },
                new[] { 4, 5, 6 },
                new[] { 7, 8, 9 },
            },
            new[] { 1, 2, 4, 7, 5, 3, 6, 8, 9 }
        ];
        yield return
        [
            new[]
            {
                new[] { 1, 2 },
                new[] { 3, 4 },
            },
            new[] { 1, 2, 3, 4 }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[][] matrix, int[] expected)
    {
        var actual = Solution.FindDiagonalOrder(matrix);
        Assert.Equal(expected, actual);
    }
}