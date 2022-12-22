// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class BackspaceCompareUnitTest
{
    private readonly Solution _solution;
    public BackspaceCompareUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("ab#c", "ad#c", true)]
    [InlineData("ab##", "c#d#", true)]
    [InlineData("a##c", "#a#c", true)]
    [InlineData("a#c", "b", false)]
    public void Test(string s, string t, bool expected)
    {
        var actual = _solution.BackspaceCompare(s, t);
        Assert.Equal(expected, actual);
    }
}
