﻿using Xunit;

namespace Leetcode.Test.SolutionTests;

public class MergeAlternatelyUnitTest
{
    private readonly Solution _solution;

    public MergeAlternatelyUnitTest()
    {
        _solution = new Solution();
    }
    

    [Theory]
    [InlineData("abc", "pqr", "apbqcr")]
    [InlineData("ab", "pqrs", "apbqrs")]
    [InlineData("abcd", "pq", "apbqcd")]
    public void Test(string word1, string word2, string expected)
    {
        var actual = _solution.MergeAlternately(word1, word2);
        Assert.Equal(expected, actual);
    }
}