// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class NumMatrixUnitTest
{
    private readonly int[][] _matrix =
    [
        new int[5] { 3, 0, 1, 4, 2 },
        new int[5] { 5, 6, 3, 2, 1 },
        new int[5] { 1, 2, 0, 1, 5 },
        new int[5] { 4, 1, 0, 1, 7 },
        new int[5] { 1, 0, 3, 0, 5 }
    ];

    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 2, 1, 4, 3 }, 8
        ];
        yield return
        [
            new[] { 1, 1, 2, 2 }, 11
        ];
        yield return
        [
            new[] { 1, 2, 2, 4 }, 12
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] points, int expected)
    {
        NumMatrix nm = new(_matrix);
        var actual = nm.SumRange(points[0], points[1], points[2], points[3]);
        Assert.Equal(expected, actual);
    }
}