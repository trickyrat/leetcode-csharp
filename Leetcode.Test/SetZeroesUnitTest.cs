// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcode.Test;

public class SetZeroesUnitTest
{
    private readonly Solution _solution;
    public SetZeroesUnitTest()
    {
        _solution = new Solution();
    }
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            new int[][]
            {
                new int[] { 1, 1, 1},
                new int[] { 1, 0, 1},
                new int[] { 1, 1, 1}
            },
            new int[][]
            {
                new int[] { 1, 0, 1},
                new int[] { 0, 0, 0},
                new int[] { 1, 0, 1}
            }
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[][] input, int[][] expected)
    {
        
        _solution.SetZeroes(input);
        Assert.Equal(input, expected);
    }
}