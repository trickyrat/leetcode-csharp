﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class MinRemoveToMakeValidUnitTest
{
    [Theory]
    [InlineData("lee(t(c)o)de)", "lee(t(c)o)de")]
    [InlineData("a)b(c)d", "ab(c)d")]
    [InlineData("))((", "")]
    public void MultipleDataTest(string testInput, string expected)
    {

        var actual = Solution.MinRemoveToMakeValid(testInput);
        Assert.Equal(expected, actual);
    }
}