// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class ValidParenthesesUnitTest
{
    private readonly Solution _solution;

    public ValidParenthesesUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("{[]}", true)]
    public void MultipleDataTest(string s, bool expected)
    {
        var actual = _solution.IsValid(s);
        Assert.Equal(expected, actual);
    }
}