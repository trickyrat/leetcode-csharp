// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

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
        bool actual = _solution.IsValid(s);
        Assert.Equal(expected, actual);
    }
}