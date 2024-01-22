// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MinPathSumUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new int[][]
            {
                [1, 2, 3, 1],
                [4, 5, 6, 1],
                [7, 8, 9, 1]
            },
            9
        ];
        yield return
        [
            new int[][]
            {
                [1,2,3,1],
                [4,2,6,1],
                [7,1,1,1]
            },
            8
        ];
        yield return
        [
            new int[][]
            {
                [1,1,1,1],
                [1,1,1,1],
                [1,1,1,1]
            },
            6
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[][] grid, int expected)
    {

        var actual = Solution.MinPathSum(grid);
        Assert.Equal(expected, actual);
    }
}
