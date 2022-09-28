// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class CalPointsUnitTest
{
    private readonly Solution _solution;
    public CalPointsUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new string[] { "5", "2", "C", "D", "+" }, 30)]
    [InlineData(new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" }, 27)]
    [InlineData(new string[] { "1" }, 1)]
    public void Test(string[] input, int expected)
    {
        var actual = _solution.CalPoints(input);
        Assert.Equal(expected, actual);
    }
}
