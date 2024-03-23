// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;
public class NumSpecialUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new int[][]
            {
                [1, 0, 0],
                [0, 0, 1],
                [1, 0, 0],
            },
            1
        ];

        yield return
        [
            new int[][]
            {
                [1, 0, 0],
                [0, 1, 0],
                [0, 0, 1],
            },
            3
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[][] mat, int expected)
    {
        var actual = Solution.NumSpecial(mat);
        Assert.Equal(expected, actual);
    }
}

