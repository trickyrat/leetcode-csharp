// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class SortedSquaresUnitTest
{
    private readonly Solution _solution;
    public SortedSquaresUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData(new int[] { -4, -1, 0, 3, 10 }, new int[] { 0, 1, 9, 16, 100 })]
    [InlineData(new int[] { 0, 3, 4, 6, 10 }, new int[] { 0, 9, 16, 36, 100 })]
    [InlineData(new int[] { -10, -6, -5, -4, -3 }, new int[] { 9, 16, 25, 36, 100 })]
    [InlineData(new int[] { -7, -3, 2, 3, 11 }, new int[] { 4, 9, 9, 49, 121 })]
    public void Test_Should_Ok(int[] nums, int[] expected)
    {
        
        int[] actual = _solution.SortedSquares(nums);
        Assert.Equal(expected, actual);
    }
}
