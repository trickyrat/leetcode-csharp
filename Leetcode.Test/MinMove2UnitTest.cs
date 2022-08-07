// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class MinMove2UnitTest
{

    private readonly Solution _solution;

    public MinMove2UnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 2)]
    [InlineData(new int[] { 1, 10, 2, 9 }, 16)]
    public void MultipleDataTest(int[] nums, int expected)
    {
        int actual = _solution.MinMove2(nums);
        Assert.Equal(expected, actual);
    }

}