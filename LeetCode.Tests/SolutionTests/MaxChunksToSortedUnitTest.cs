// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class MaxChunksToSortedUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 4, 3, 2, 1, 0 }, 1
        ];

        yield return
        [
            new[] { 1, 0, 2, 3, 4 }, 4
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] arr, int expected)
    {
        var actual = Solution.MaxChunksToSorted(arr);
        Assert.Equal(expected, actual);
    }
}