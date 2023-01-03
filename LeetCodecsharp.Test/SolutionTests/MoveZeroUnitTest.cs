// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class MoveZeroUnitTest
{
    private readonly Solution _solution;
    public MoveZeroUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
    [InlineData(new int[] { 0 }, new int[] { 0 })]
    public void Test(int[] nums, int[] expected)
    {

        _solution.MoveZeroes(nums);
        Assert.Equal(expected, nums);
    }
}
