// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class MergeAlternatelyUnitTest
{
    [Theory]
    [InlineData("abc", "pqr", "apbqcr")]
    [InlineData("ab", "pqrs", "apbqrs")]
    [InlineData("abcd", "pq", "apbqcd")]
    public void Test(string word1, string word2, string expected)
    {
        var actual = Solution.MergeAlternately(word1, word2);
        Assert.Equal(expected, actual);
    }
}