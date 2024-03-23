// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class MaxAscendingSumUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 10, 20, 30, 5, 10, 50 }, 65
        ];

        yield return
        [
            new[] { 10, 20, 30, 40, 50 }, 150
        ];

        yield return
        [
            new[] { 12, 17, 15, 13, 10, 11, 12 }, 33
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] arr, int expected)
    {
        var actual = Solution.MaxAscendingSum(arr);
        Assert.Equal(expected, actual);
    }
}