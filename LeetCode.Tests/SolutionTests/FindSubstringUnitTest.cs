// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class FindSubstringUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            "barfoothefoobarman",
            new[] { "foo", "bar" },
            new[] { 0, 9 }
        ];

        yield return
        [
            "wordgoodgoodgoodbestword",
            new[] { "word", "good", "best", "word" },
            Array.Empty<int>()
        ];

        yield return
        [
            "barfoofoobarthefoobarman",
            new[] { "bar", "foo", "the" },
            new[] { 6, 9, 12 }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(string s, string[] words, IList<int> expected)
    {
        var actual = Solution.FindSubstring(s, words);
        Assert.Equal(expected, actual);
    }
}