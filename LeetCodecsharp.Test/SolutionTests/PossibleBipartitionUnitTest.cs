// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class PossibleBipartitionUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            4,
            new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 1, 3 },
                new int[] { 2, 4 }
            },
            true
        };

        yield return new object[]
        {
            3,
            new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 1, 3 },
                new int[] { 2, 3 }
            },
            false
        };
        yield return new object[]
        {
            5,
            new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 4, 5 },
                new int[] { 1, 5 },
            },
            false
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int n, int[][] dislikes, bool expected)
    {
        var actual = Solution.PossibleBipartition(n, dislikes);
        Assert.Equal(expected, actual);
    }
}