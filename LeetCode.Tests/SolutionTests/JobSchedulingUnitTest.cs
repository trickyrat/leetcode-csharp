// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class JobSchedulingUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 2, 3, 3 }, new[] { 3, 4, 5, 6 }, new[] { 50, 10, 40, 70 }, 120
        ];

        yield return
        [
            new[] { 1, 2, 3, 4, 6 }, new[] { 3, 5, 10, 6, 9 }, new[] { 20, 20, 100, 70, 60 }, 150
        ];

        yield return
        [
            new[] { 1, 1, 1 }, new[] { 2, 3, 4 }, new[] { 5, 6, 4 }, 6
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] startTime, int[] endTime, int[] profit, int expected)
    {
        var actual = Solution.JobScheduling(startTime, endTime, profit);
        Assert.Equal(expected, actual);
    }
}