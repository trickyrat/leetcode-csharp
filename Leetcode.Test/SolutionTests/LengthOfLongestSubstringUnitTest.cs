// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class LengthOfLongestSubstringUnitTest
{
    private readonly Solution _solution;
    public LengthOfLongestSubstringUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("", 0)]
    public void Test_Input_Palindromic_Alphas_Should_OK(string s, int expected)
    {

        var actual = _solution.LengthOfLongestSubstring(s);
        Assert.Equal(expected, actual);
    }
}
