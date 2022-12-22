// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCode.Test.SolutionTests;
public class NumSpecialUnitTest
{
    private readonly Solution _solution;

    public NumSpecialUnitTest()
    {
        _solution = new Solution();
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            new int[][]
            {
                new int[]{ 1, 0, 0 },
                new int[]{ 0, 0, 1 },
                new int[]{ 1, 0, 0 },
            },
            1
        };

        yield return new object[]
        {
            new int[][]
            {
                new int[]{ 1, 0, 0 },
                new int[]{ 0, 1, 0 },
                new int[]{ 0, 0, 1 },
            },
            3
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[][] mat, int expected)
    {
        var actual = _solution.NumSpecial(mat);
        Assert.Equal(expected, actual);
    }
}

