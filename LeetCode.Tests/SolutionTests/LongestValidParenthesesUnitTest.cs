﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class LongestValidParenthesesUnitTest
{
    [Theory]
    [InlineData("()()()(()", 6)]
    [InlineData("(()", 2)]
    [InlineData("()()()(())", 10)]
    public void Test(string s, int expected)
    {

        var actual = Solution.LongestValidParentheses(s);
        Assert.Equal(expected, actual);
    }
}
