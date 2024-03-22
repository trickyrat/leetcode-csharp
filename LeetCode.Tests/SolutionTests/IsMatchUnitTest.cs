// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class IsMatchUnitTest
{
    [Theory]
    [InlineData("aa", "a", false)]
    [InlineData("aa", "a*", true)]
    [InlineData("ab", ".*", true)]
    public void MultipleDataTest(string s, string p, bool expected)
    {

        var actual = Solution.IsMatch(s, p);
        Assert.Equal(expected, actual);
    }
}