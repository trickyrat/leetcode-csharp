// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class NextPermutationUnitTest
{
    private readonly Solution _solution;

    public NextPermutationUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 3, 2 })]
    [InlineData(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 1, 1, 5 }, new int[] { 1, 5, 1 })]
    public void MultipleDataTest(int[] nums, int[] expected)
    {
        _solution.NextPermutation(nums);
        Assert.Equal(expected, nums);
    }
}