// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class MaxIncreaseKeepingSkylineUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new int[][]
            {
                [3, 0, 8, 4],
                [2, 4, 5, 7],
                [9, 2, 6, 3],
                [0, 3, 1, 0],
            },
            35
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[][] grid, int expected)
    {
        var actual = Solution.MaxIncreaseKeepingSkyline(grid);
        Assert.Equal(expected, actual);
    }
}