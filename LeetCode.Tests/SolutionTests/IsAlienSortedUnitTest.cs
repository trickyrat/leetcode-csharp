// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class IsAlienSortedUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { "hello", "leetcode" }, "hlabcdefgijkmnopqrstuvwxyz", true
        ];

        yield return
        [
            new[] { "word", "world", "row" }, "worldabcefghijkmnpqstuvxyz", false
        ];

        yield return
        [
            new[] { "apple", "app" }, "abcdefghijklmnopqrstuvwxyz", false
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(string[] words, string order, bool expected)
    {
        var actual = Solution.IsAlienSorted(words, order);
        Assert.Equal(expected, actual);
    }
}