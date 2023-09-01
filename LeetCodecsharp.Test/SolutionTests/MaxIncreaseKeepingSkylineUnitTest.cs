// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MaxIncreaseKeepingSkylineUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            new int[][]
            {
                new int[] {3, 0, 8, 4},
                new int[] {2, 4, 5, 7},
                new int[] {9, 2, 6, 3},
                new int[] {0, 3, 1, 0},
            },
            35
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[][] grid, int expected)
    {
        var actual = Solution.MaxIncreaseKeepingSkyline(grid);
        Assert.Equal(expected, actual);
    }
}