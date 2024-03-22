// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class CountOddsUnitTest
{
    [Theory]
    [InlineData(3, 7, 3)]
    [InlineData(8, 10, 1)]
    public void MultipleDataTest(int low, int high, int expected)
    {
        var actual = Solution.CountOdds(low, high);
        Assert.Equal(expected, actual);
    }

}