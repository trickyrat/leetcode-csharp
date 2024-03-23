// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class CountMaxOrSubsetsUniTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 3, 1 }, 2
        ];
        yield return
        [
            new[] { 2, 2, 2 }, 7
        ];

        yield return
        [
            new[] { 3, 2, 1, 5 }, 6
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] input, int expect)
    {
        var actual = Solution.CountMaxOrSubsets(input);
        Assert.Equal(expect, actual);
    }
}