// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class AddDigitsUnitTest
{
    [Theory]
    [InlineData(38, 2)]
    [InlineData(0, 0)]
    [InlineData(int.MaxValue, 1)]
    public void MultipleDataTest(int input, int expected)
    {
        var actual = Solution.AddDigits(input);
        Assert.Equal(expected, actual);
    }
}