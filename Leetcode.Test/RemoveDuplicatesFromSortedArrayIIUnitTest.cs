// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class RemoveDuplicatesFromSortedArrayIIUnitTest
{
    private readonly Solution _solution;
    public RemoveDuplicatesFromSortedArrayIIUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 1, 1, 1, 2, 2, 3 }, 5)]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }, 7)]
    public void Test(int[] nums, int expected)
    {
        var actual = _solution.RemoveDuplicatesV2(nums);
        Assert.Equal(expected, actual);
    }
}
