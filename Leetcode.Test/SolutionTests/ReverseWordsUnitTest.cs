// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;

public class ReverseWordsUnitTest
{
    private readonly Solution _solution;
    public ReverseWordsUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
    [InlineData("God Ding", "doG gniD")]
    public void Test1(string s, string expected)
    {

        var actual = _solution.ReverseWords(s);
        Assert.Equal(expected, actual);
    }
}
