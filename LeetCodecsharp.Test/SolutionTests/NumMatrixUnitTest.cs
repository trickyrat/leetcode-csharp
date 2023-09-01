// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class NumMatrixUnitTest
{

    private readonly int[][] _matrix =
    {
        new int[5]{ 3,0,1,4,2},
        new int[5]{ 5,6,3,2,1},
        new int[5]{ 1,2,0,1,5},
        new int[5]{ 4,1,0,1,7},
        new int[5]{ 1,0,3,0,5},
    };

    [Theory]
    [InlineData(new int[] { 2, 1, 4, 3 }, 8)]
    [InlineData(new int[] { 1, 1, 2, 2 }, 11)]
    [InlineData(new int[] { 1, 2, 2, 4 }, 12)]
    public void Test(int[] points, int expected)
    {
        NumMatrix nm = new(_matrix);
        var actual = nm.SumRange(points[0], points[1], points[2], points[3]);
        Assert.Equal(expected, actual);
    }
}
