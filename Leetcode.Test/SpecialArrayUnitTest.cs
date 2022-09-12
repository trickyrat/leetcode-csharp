// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;
public class SpecialArrayUnitTest
{
    private readonly Solution _solution;

    public SpecialArrayUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(new int[] { 3, 5 }, 2)]
    [InlineData(new int[] { 0, 0 }, -1)]
    [InlineData(new int[] { 0, 4, 3, 0, 4 }, 3)]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = _solution.SpecialArray(nums);
        Assert.Equal(expected, actual);
    }
}

