// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class CountStudentsUnitTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 0, 0 }, new int[] { 0, 1, 0, 1 }, 0)]
    [InlineData(new int[] { 1, 1, 1, 0, 0, 1 }, new int[] { 1, 0, 0, 0, 1, 1 }, 3)]
    public void MultipleDataTest(int[] students, int[] sandwiches, int expected)
    {
        var actual = Solution.CountStudents(students, sandwiches);
        Assert.Equal(expected, actual);
    }
}

