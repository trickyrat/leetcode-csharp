// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class MostCommonWordUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            "Bob hit a ball, the hit BALL flew far after it was hit.",
            new[] { "hit" },
            "ball"
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(string paragraph, string[] banned, string expected)
    {
        var actual = Solution.MostCommonWord(paragraph, banned);
        Assert.Equal(expected, actual);
    }
}