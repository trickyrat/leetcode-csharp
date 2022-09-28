// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class MergeUnitTest
{
    private readonly Solution _solution;
    public MergeUnitTest()
    {
        _solution = new Solution();
    }
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 2, 6 },
                new int[] { 8, 10 },
                new int[] { 15, 18 }
            },
            new int[][]
            {
                new int[] { 1, 6 },
                new int[] { 8, 10 },
                new int[] { 15, 18 }
            }
        };
        yield return new object[]
        {
            new int[][]
            {
                new int[] { 1, 4 },
                new int[] { 4, 5 },
            },
            new int[][]
            {
                new int[] { 1, 5 }
            }
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[][] input, int[][] expected)
    {

        var actual = _solution.Merge(input);
        Assert.Equal(expected, actual);
    }
}