// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test;

public class LongestValidParenthesesUnitTest
{
    private readonly Solution _solution;
    public LongestValidParenthesesUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData("()()()(()", 6)]
    [InlineData("(()", 2)]
    [InlineData("()()()(())", 10)]
    public void Test(string s, int expected)
    {
        
        int actual = _solution.LongestValidParentheses(s);
        Assert.Equal(expected, actual);
    }
}
