// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class CheckInclusionUnitTest
{
    private readonly Solution _solution;
    public CheckInclusionUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("ab", "eidbaooo", true)]
    [InlineData("ab", "eidboaoo", false)]
    public void Test_Should_Return_True(string s1, string s2, bool expected)
    {
        var actual = _solution.CheckInclusion(s1, s2);
        Assert.Equal(expected, actual);
    }
}
