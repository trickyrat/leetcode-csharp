// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MinMovesToSeatUnitTest
{
    [Theory]
    [InlineData(new int[] { 3, 1, 5 }, new int[] { 2, 7, 4 }, 4)]
    [InlineData(new int[] { 4, 1, 5, 9 }, new int[] { 1, 3, 2, 6 }, 7)]
    [InlineData(new int[] { 2, 2, 6, 6 }, new int[] { 1, 3, 2, 6 }, 4)]
    public void Test(int[] seats, int[] students, int expected)
    {
        var actual = Solution.MinMovesToSeat(seats, students);
        Assert.Equal(expected, actual);
    }
}