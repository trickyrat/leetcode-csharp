// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class TrapUnitTest
{
    private readonly Solution _solution;

    public TrapUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
    [InlineData(new int[] { 4, 2, 0, 3, 2, 5 }, 9)]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = _solution.Trap(nums);
        Assert.Equal(expected, actual);
    }

}