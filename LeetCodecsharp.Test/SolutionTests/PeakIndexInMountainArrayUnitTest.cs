// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class PeakIndexInMountainArrayUnitTest
{
    private readonly Solution _solution;
    public PeakIndexInMountainArrayUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData(new int[] { 18, 29, 38, 59, 98, 100, 99, 98, 90 }, 5)]
    [InlineData(new int[] { 0, 1, 0 }, 1)]
    [InlineData(new int[] { 1, 3, 5, 4, 2 }, 2)]
    [InlineData(new int[] { 0, 10, 5, 2 }, 1)]
    public void Test(int[] arr, int expected)
    {

        var actual = _solution.PeakIndexInMountainArray(arr);
        Assert.Equal(expected, actual);
    }
}
