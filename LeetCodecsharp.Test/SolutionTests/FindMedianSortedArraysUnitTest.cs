// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class FindMedianSortedArraysUnitTest
{

    private readonly Solution _solution;
    public FindMedianSortedArraysUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2.00000)]
    [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.50000)]
    public void MultipleDataTest(int[] A, int[] B, double expected)
    {

        var actual = _solution.FindMedianSortedArrays(A, B);
        Assert.Equal(expected, actual);
    }
}