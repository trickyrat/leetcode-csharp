// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class MinPathSumUnitTest
{
    private readonly Solution _solution;
    public MinPathSumUnitTest()
    {
        _solution = new Solution();
    }
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[] {
            new int[][]
            {
                new int[] {1, 2, 3, 1},
                new int[] {4, 5, 6, 1},
                new int[] {7, 8, 9, 1}
            },
            9
        };
        yield return new object[] {
            new int[][]
            {
                new int[]{ 1,2,3,1},
                new int[]{ 4,2,6,1},
                new int[]{ 7,1,1,1}
            },
            8
        };
        yield return new object[] {
            new int[][]
            {
                new int[]{ 1,1,1,1},
                new int[]{ 1,1,1,1},
                new int[]{ 1,1,1,1}
            },
            6
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[][] grid, int expected)
    {

        var actual = _solution.MinPathSum(grid);
        Assert.Equal(expected, actual);
    }
}
