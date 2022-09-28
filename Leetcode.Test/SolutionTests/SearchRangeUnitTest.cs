// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class SearchRangeUnitTest
{
    private readonly Solution _solution;
    public SearchRangeUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 8, new int[] { 3, 4 })]
    [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 6, new int[] { -1, -1 })]
    [InlineData(new int[] { }, 0, new int[] { -1, -1 })]
    public void Test(int[] nums, int target, int[] expected)
    {

        var actual = _solution.SearchRange(nums, target);
        Assert.Equal(expected, actual);
    }
}
