// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCode.Test.SolutionTests;
public class GenerateMatrixUnitTest
{
    private readonly Solution _solution;

    public GenerateMatrixUnitTest()
    {
        _solution = new Solution();
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            3,
            new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 8, 9, 4 },
                new int[] { 7, 6, 5 }
            }
        };
        yield return new object[]
        {
            1,
            new int[][]
            {
                new int[] { 1 }
            }
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int n, int[][] expected)
    {
        var actual = _solution.GenerateMatrix(n);
        Assert.Equal(expected, actual);
    }

}

