// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCode.Tests.SolutionTests;
public class GenerateMatrixUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            3,
            new int[][]
            {
                [1, 2, 3],
                [8, 9, 4],
                [7, 6, 5]
            }
        ];
        yield return
        [
            1,
            new int[][]
            {
                [1]
            }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int n, int[][] expected)
    {
        var actual = Solution.GenerateMatrix(n);
        Assert.Equal(expected, actual);
    }

}

