// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class MinDeletionSizeUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { "cba", "daf", "ghi" }, 1
        ];

        yield return
        [
            new[] { "a", "b" }, 0
        ];

        yield return
        [
            new[] { "zyx", "wvu", "tsr" }, 3
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(string[] strs, int expected)
    {
        var actual = Solution.MinDeletionSize(strs);
        Assert.Equal(expected, actual);
    }
}