﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class ReverseWordsUnitTest
{
    [Theory]
    [InlineData("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
    [InlineData("God Ding", "doG gniD")]
    public void Test1(string s, string expected)
    {

        var actual = Solution.ReverseWords(s);
        Assert.Equal(expected, actual);
    }
}
