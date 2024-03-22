// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class LetterCombinationsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            "23", new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }
        ];

        yield return
        [
            "", new string[] { }
        ];

        yield return
        [
            "2", new[] { "a", "b", "c" }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(string digits, string[] expected)
    {
        var actual = Solution.LetterCombinations(digits);
        Assert.Equal(expected, actual);
    }
}