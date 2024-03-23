// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class PrefixCountUnitTest
{
    [Theory]
    [InlineData(new string[] { "pay", "attention", "practice", "attend" }, "at", 2)]
    [InlineData(new string[] { "leetcode", "win", "loops", "success" }, "code", 0)]
    public void MultipleDataTest(string[] words, string pref, int expected)
    {
        var actual = Solution.PrefixCount(words, pref);
        Assert.Equal(expected, actual);
    }


}