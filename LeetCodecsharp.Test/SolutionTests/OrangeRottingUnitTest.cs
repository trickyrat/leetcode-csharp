// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class OrangeRottingUnitTest
{
    private readonly Solution _solution;
    public OrangeRottingUnitTest()
    {
        _solution = new Solution();
    }
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

        var actual = _solution.OrangeRotting(grid);
        Assert.Equal(expected, actual);
    }
}
