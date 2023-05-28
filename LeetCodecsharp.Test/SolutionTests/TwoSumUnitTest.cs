// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class TwoSumUnitTest
{
    private readonly Solution _solution;

    public TwoSumUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoSumTest1(int[] nums, int target, int[] expected)
    {
        var actual = _solution.TwoSum(nums, target);
        Assert.Equal(expected, actual);
    }
}
