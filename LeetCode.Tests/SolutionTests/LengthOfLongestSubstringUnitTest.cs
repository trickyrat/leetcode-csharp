﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class LengthOfLongestSubstringUnitTest
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("", 0)]
    public void Test_Input_Palindromic_Alphas_Should_OK(string s, int expected)
    {

        var actual = Solution.LengthOfLongestSubstring(s);
        Assert.Equal(expected, actual);
    }
}
