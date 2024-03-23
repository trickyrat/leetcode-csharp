// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class CountNumbersWithUniqueDigitsUnitTest
{
    [Theory]
    [InlineData(2, 91)]
    [InlineData(0, 1)]
    public void MultipleDataTest(int n, int expected)
    {
        var actual = Solution.CountNumbersWithUniqueDigits(n);
        Assert.Equal(expected, actual);
    }
}