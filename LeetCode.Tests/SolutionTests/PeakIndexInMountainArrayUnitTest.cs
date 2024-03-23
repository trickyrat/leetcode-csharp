// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class PeakIndexInMountainArrayUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 18, 29, 38, 59, 98, 100, 99, 98, 90 }, 5
        ];
        yield return
        [
            new[] { 0, 1, 0 }, 1
        ];
        yield return
        [
            new[] { 1, 3, 5, 4, 2 }, 2
        ];
        yield return
        [
            new[] { 0, 10, 5, 2 }, 1
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] arr, int expected)
    {
        var actual = Solution.PeakIndexInMountainArray(arr);
        Assert.Equal(expected, actual);
    }
}