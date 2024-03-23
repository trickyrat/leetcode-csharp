// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class FindPeakElementUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 2, 3, 1 }, 2
        ];

        yield return
        [
            new[] { 1, 2, 1, 3, 5, 6, 4 }, 5
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] arr, int expected)
    {
        var actual = Solution.FindPeakElement(arr);
        Assert.Equal(expected, actual);
    }
}