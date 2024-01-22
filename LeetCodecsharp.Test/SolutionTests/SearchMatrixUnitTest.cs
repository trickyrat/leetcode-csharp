// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class SearchMatrixUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new int[][]
            {
                [1, 3, 5, 7],
                [10, 11, 16, 20],
                [23, 30, 34, 60]
            },
            3,
            true
        ];
        yield return
        [
            new int[][]
            {
                [1, 3, 5, 7],
                [10, 11, 16, 20],
                [23, 30, 34, 60]
            },
            13,
            false
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[][] matrix, int target, bool expected)
    {
        var actual = Solution.SearchMatrix(matrix, target);
        Assert.Equal(expected, actual);
    }
}