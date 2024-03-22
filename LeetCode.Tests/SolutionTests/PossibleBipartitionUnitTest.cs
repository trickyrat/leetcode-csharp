// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class PossibleBipartitionUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            4,
            new int[][]
            {
                [1, 2],
                [1, 3],
                [2, 4]
            },
            true
        ];

        yield return
        [
            3,
            new int[][]
            {
                [1, 2],
                [1, 3],
                [2, 3]
            },
            false
        ];
        yield return
        [
            5,
            new int[][]
            {
                [1, 2],
                [2, 3],
                [3, 4],
                [4, 5],
                [1, 5],
            },
            false
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int n, int[][] dislikes, bool expected)
    {
        var actual = Solution.PossibleBipartition(n, dislikes);
        Assert.Equal(expected, actual);
    }
}