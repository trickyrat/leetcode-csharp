// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class IsAlienSortedUnitTest
{
    [Theory]
    [InlineData(new string[] { "hello", "leetcode" }, "hlabcdefgijkmnopqrstuvwxyz", true)]
    [InlineData(new string[] { "word", "world", "row" }, "worldabcefghijkmnpqstuvxyz", false)]
    [InlineData(new string[] { "apple", "app" }, "abcdefghijklmnopqrstuvwxyz", false)]
    public void Test(string[] words, string order, bool expected)
    {
        var actual = Solution.IsAlienSorted(words, order);
        Assert.Equal(expected, actual);
    }
}
