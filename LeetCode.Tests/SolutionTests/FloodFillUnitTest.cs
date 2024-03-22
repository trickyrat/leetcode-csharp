// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class FloodFillUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new int[][]
            {
                [1, 1, 1],
                [1, 1, 0],
                [1, 0, 1],
            },
            1,
            1,
            2,
            new int[][]
            {
                [2, 2, 2],
                [2, 2, 0],
                [2, 0, 1],
            }
        ];
        yield return
        [
            new int[][]
            {
                [0, 0, 0],
                [0, 0, 0]
            },
            0,
            0,
            2,
            new int[][]
            {
                [2, 2, 2],
                [2, 2, 2]
            }
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[][] input, int sr, int sc, int newColor, int[][] expected)
    {

        var actual = Solution.FloodFill(input, sr, sc, newColor);
        Assert.Equal(expected, actual);
    }
}
