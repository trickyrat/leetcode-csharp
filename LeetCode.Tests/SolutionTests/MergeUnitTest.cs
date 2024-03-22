// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class MergeUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new int[][]
            {
                [1, 3],
                [2, 6],
                [8, 10],
                [15, 18]
            },
            new int[][]
            {
                [1, 6],
                [8, 10],
                [15, 18]
            }
        ];
        yield return
        [
            new int[][]
            {
                [1, 4],
                [4, 5],
            },
            new int[][]
            {
                [1, 5]
            }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[][] input, int[][] expected)
    {

        var actual = Solution.Merge(input);
        Assert.Equal(expected, actual);
    }
}