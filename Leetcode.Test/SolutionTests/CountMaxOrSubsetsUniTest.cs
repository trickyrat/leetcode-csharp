// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class CountMaxOrSubsetsUniTest
{
    private readonly Solution _solution;

    public CountMaxOrSubsetsUniTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 3, 1 }, 2)]
    [InlineData(new int[] { 2, 2, 2 }, 7)]
    [InlineData(new int[] { 3, 2, 1, 5 }, 6)]
    public void MultipleDataTest(int[] input, int expect)
    {
        var actual = _solution.CountMaxOrSubsets(input);
        Assert.Equal(expect, actual);
    }
}