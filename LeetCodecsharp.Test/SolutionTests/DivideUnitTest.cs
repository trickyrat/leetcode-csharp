// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class DivideUnitTest
{
    private readonly Solution _solution;

    public DivideUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(10, 3, 3)]
    [InlineData(7, -3, -2)]
    [InlineData(0, 1, 0)]
    [InlineData(1, 1, 1)]
    public void Test(int dividend, int divisor, int expected)
    {
        var actual = _solution.Divide(dividend, divisor);
        Assert.Equal(expected, actual);
    }
}
