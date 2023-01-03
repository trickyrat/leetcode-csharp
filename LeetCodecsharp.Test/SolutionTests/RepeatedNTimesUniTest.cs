// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class RepeatedNTimesUniTest
{
    private readonly Solution _solution;

    public RepeatedNTimesUniTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 3 }, 3)]
    [InlineData(new int[] { 2, 1, 2, 5, 3, 2 }, 2)]
    [InlineData(new int[] { 5, 1, 5, 2, 5, 3, 5, 4 }, 5)]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = _solution.RepeatedNTimes(nums);
        Assert.Equal(expected, actual);
    }
}