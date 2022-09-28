// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class TwoSumIIUnitTest
{
    private readonly Solution _solution;
    public TwoSumIIUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
    [InlineData(new int[] { 2, 3, 4 }, 6, new int[] { 1, 3 })]
    [InlineData(new int[] { -1, 0 }, -1, new int[] { 1, 2 })]
    public void Test1(int[] numbers, int target, int[] expected)
    {

        var actual = _solution.TwoSumII(numbers, target);
        Assert.Equal(expected, actual);
    }
}
