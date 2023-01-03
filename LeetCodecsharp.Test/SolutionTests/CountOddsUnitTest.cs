// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class CountOddsUnitTest
{
    private readonly Solution _solution;

    public CountOddsUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(3, 7, 3)]
    [InlineData(8, 10, 1)]
    public void MultipleDataTest(int low, int high, int expected)
    {
        var actual = _solution.CountOdds(low, high);
        Assert.Equal(expected, actual);
    }

}