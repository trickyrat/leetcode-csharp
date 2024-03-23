// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class MaxDifferenceUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 7, 1, 5, 4 }, 4
        ];

        yield return
        [
            new[] { 9, 4, 3, 2 }, -1
        ];

        yield return
        [
            new[] { 1, 5, 2, 10 }, 9
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] input, int expected)
    {
        var actual = Solution.MaximumDifference(input);
        Assert.Equal(expected, actual);
    }
}