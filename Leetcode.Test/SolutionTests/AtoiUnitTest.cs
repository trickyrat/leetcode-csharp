// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class AtoiUnitTest
{
    private readonly Solution _solution;
    public AtoiUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData("42", 42)]
    [InlineData("   -42", -42)]
    [InlineData("4193 with words", 4193)]
    public void MultipleDataTest(string input, int expected)
    {
        var actual = _solution.Atoi(input);
        Assert.Equal(expected, actual);
    }
}