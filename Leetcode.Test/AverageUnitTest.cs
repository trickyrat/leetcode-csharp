// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class AverageUnitTest
{
    private readonly Solution _solution;

    public AverageUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 4000, 3000, 1000, 2000 }, 2500.00000)]
    [InlineData(new int[] { 1000, 2000, 3000 }, 2000.00000)]
    public void MultipleDataTest(int[] salary, double expected)
    {
        double actual = _solution.Average(salary);
        Assert.Equal(expected, actual);
    }

}