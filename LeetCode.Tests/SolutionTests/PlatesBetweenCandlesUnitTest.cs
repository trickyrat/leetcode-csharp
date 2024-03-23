// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class PlatesBetweenCandlesUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            "**|**|***|",
            new int[][]
            {
                [2,5],
                [5,9]
            },
            new[] { 2,3 }
        ];
        yield return
        [
            "***|**|*****|**||**|*",
            new int[][]
            {
                [1, 17],
                [4, 5],
                [14, 17],
                [5, 11],
                [15, 16],
            },
            new[] { 9,0,0,0,0 }
        ];
    }
    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(string s, int[][] queries, int[] expected)
    {

        var actual = Solution.PlatesBetweenCandles(s, queries);
        Assert.Equal(expected, actual);
    }
}
