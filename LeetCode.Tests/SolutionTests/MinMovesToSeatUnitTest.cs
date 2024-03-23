// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class MinMovesToSeatUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 3, 1, 5 }, new[] { 2, 7, 4 }, 4
        ];

        yield return
        [
            new[] { 4, 1, 5, 9 }, new[] { 1, 3, 2, 6 }, 7
        ];

        yield return
        [
            new[] { 2, 2, 6, 6 }, new[] { 1, 3, 2, 6 }, 4
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] seats, int[] students, int expected)
    {
        var actual = Solution.MinMovesToSeat(seats, students);
        Assert.Equal(expected, actual);
    }
}