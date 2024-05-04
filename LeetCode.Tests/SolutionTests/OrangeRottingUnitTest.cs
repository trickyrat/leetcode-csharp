﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class OrangeRottingUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 0, 1, 1 }
            },
            4
        };
        yield return new object[]
        {
            new int[][]
            {
                new int[] { 0, 2 }
            },
            0
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[][] grid, int expected)
    {

        var actual = Solution.OrangeRotting(grid);
        Assert.Equal(expected, actual);
    }
}
