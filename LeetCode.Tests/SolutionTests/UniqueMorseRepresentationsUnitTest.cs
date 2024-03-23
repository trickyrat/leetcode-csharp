// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class UniqueMorseRepresentationsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { "gin", "zen", "gig", "msg" }, 2
        ];
        yield return
        [
            new[] { "a" }, 1
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(string[] words, int expected)
    {
        var actual = Solution.UniqueMorseRepresentations(words);
        Assert.Equal(expected, actual);
    }
}