// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class MyPowUnitTest
{
    private readonly Solution _solution;

    public MyPowUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(2.00000d, 10, 1024.00000d)]
    [InlineData(2.10000d, 3, 9.26100d)]
    [InlineData(2.00000d, -2, 0.25000d)]
    public void MultipleDataTest(double x, int n, double expected)
    {
        var actual = _solution.MyPow(x, n);
        Assert.Equal((decimal)expected, (decimal)actual);
    }
}

