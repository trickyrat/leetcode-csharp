// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class FirstMissingPositiveUnitTest
{
    private readonly Solution _solution;

    public FirstMissingPositiveUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 0 }, 3)]
    [InlineData(new int[] { 3, 4, -1, 1 }, 2)]
    [InlineData(new int[] { 7, 8, 9, 11, 12 }, 1)]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = _solution.FirstMissingPositive(nums);
        Assert.Equal(expected, actual);
    }
}