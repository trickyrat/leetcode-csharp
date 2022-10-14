// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;
public class DistinctSubseqIIUnitTest
{
    private readonly Solution _solution;

    public DistinctSubseqIIUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData("abc", 7)]
    [InlineData("aba", 6)]
    [InlineData("aaa", 3)]
    public void MultipleDataTest(string s, int expected)
    {
        var actual = _solution.DistinctSubseqII(s);
        Assert.Equal(expected, actual);
    }
}

