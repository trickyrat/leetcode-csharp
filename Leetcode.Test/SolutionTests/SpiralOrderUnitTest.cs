// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcode.Test.SolutionTests;
public class SpiralOrderUnitTest
{
    private readonly Solution _solution;

    public SpiralOrderUnitTest()
    {
        _solution = new Solution();
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            new int[][]
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 5, 6, 7, 8 },
                new int[] { 9, 10, 11, 12 }
            },
            new List<int> { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }
        };
        yield return new object[]
        {
             new int[][]
             {
                 new int[] { 1, 2, 3 },
                 new int[] { 4, 5, 6 },
                 new int[] { 7, 8, 9 }
             },
             new List<int> { 1, 2, 3, 6, 9, 8, 7, 4, 5 }
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[][] matrix, IList<int> expected)
    {
        var actual = _solution.SpiralOrder(matrix);
        Assert.Equal(expected, actual);
    }

}

