// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class MaxAreaUnitTest
{
    private readonly Solution _solution;
    public MaxAreaUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    [InlineData(new int[] { 1, 1 }, 1)]
    public void MultipleDataTest(int[] height, int expected)
    {

        var actual = _solution.MaxArea(height);
        Assert.Equal(expected, actual);
    }
}