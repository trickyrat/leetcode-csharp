// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class LongestCommonPrefixUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { "flower", "flow", "flight" }, "fl"
        ];

        yield return
        [
            new[] { "dog", "racecar", "car" }, ""
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(string[] strs, string expected)
    {
        var actual = Solution.LongestCommonPrefix(strs);
        Assert.Equal(expected, actual);
    }
}