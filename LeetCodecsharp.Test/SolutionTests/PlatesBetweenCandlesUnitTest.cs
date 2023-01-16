// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class PlatesBetweenCandlesUnitTest
{
    private readonly Solution _solution;
    public PlatesBetweenCandlesUnitTest()
    {
        _solution = new Solution();
    }
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            "**|**|***|",
            new int[][]
            {
                new int[] { 2,5 },
                new int[] { 5,9 }
            },
            new int[] { 2,3 }
        };
        yield return new object[]
        {
            "***|**|*****|**||**|*",
            new int[][]
            {
                new int[] { 1, 17 },
                new int[] { 4, 5 },
                new int[] { 14, 17 },
                new int[] { 5, 11 },
                new int[] { 15, 16 },
            },
            new int[] { 9,0,0,0,0 }
        };
    }
    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(string s, int[][] queries, int[] expected)
    {

        var actual = _solution.PlatesBetweenCandles(s, queries);
        Assert.Equal(expected, actual);
    }
}
