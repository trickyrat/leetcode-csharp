// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class MinSwapUnitTest
{
    private readonly Solution _solution;

    public MinSwapUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 1, 3, 5, 4 }, new int[] { 1, 2, 3, 7 }, 1)]
    [InlineData(new int[] { 0, 3, 5, 8, 9 }, new int[] { 2, 1, 4, 6, 9 }, 1)]
    public void MultipleDataTest(int[] nums1, int[] nums2, int expected)
    {
        var actual = _solution.MinSwap(nums1, nums2);
        Assert.Equal(expected, actual);
    }
}

