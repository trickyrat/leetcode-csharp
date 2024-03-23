// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class SpiralOrderUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new int[][]
            {
                [1, 2, 3, 4],
                [5, 6, 7, 8],
                [9, 10, 11, 12]
            },
            new List<int> { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }
        ];
        yield return
        [
            new int[][]
            {
                [1, 2, 3],
                [4, 5, 6],
                [7, 8, 9]
            },
            new List<int> { 1, 2, 3, 6, 9, 8, 7, 4, 5 }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[][] matrix, IList<int> expected)
    {
        var actual = Solution.SpiralOrder(matrix);
        Assert.Equal(expected, actual);
    }
}