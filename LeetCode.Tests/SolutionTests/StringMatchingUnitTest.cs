// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class StringMatchingUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { "mass", "as", "hero", "superhero" }, new[] { "as", "hero" }
        ];
        yield return
        [
            new[] { "leetcode", "et", "code" }, new[] { "et", "code" }
        ];
        yield return
        [
            new[] { "blue", "green", "bu" }, new string[] { }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(string[] words, IList<string> expected)
    {
        var actual = Solution.StringMatching(words);
        Assert.Equal(expected, actual);
    }
}