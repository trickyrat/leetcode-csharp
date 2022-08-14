// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;
public class CanJumpUnitTest
{
    private readonly Solution _solution;

    public CanJumpUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 2, 3, 1, 1, 4 }, true)]
    [InlineData(new int[] { 3, 2, 1, 0, 4 }, false)]
    public void MultipleDataTest(int[] nums, bool expected)
    {
        var actual = _solution.CanJump(nums);
        Assert.Equal(expected, actual);
    }
}

