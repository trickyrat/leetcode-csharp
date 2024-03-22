// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class ScoreOfParenthesesUnitTest
{
    [Theory]
    [InlineData("()", 1)]
    [InlineData("(())", 2)]
    [InlineData("()()", 2)]
    public void Test(string s, int expected)
    {
        var actual = Solution.ScoreOfParentheses(s);
        Assert.Equal(expected, actual);
    }
}