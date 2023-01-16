// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class CountNumbersWithUniqueDigitsUnitTest
{
    private readonly Solution _solution;

    public CountNumbersWithUniqueDigitsUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(2, 91)]
    [InlineData(0, 1)]
    public void MultipleDataTest(int n, int expected)
    {
        var actual = _solution.CountNumbersWithUniqueDigits(n);
        Assert.Equal(expected, actual);
    }
}