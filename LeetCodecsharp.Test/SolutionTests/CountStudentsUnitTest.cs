// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class CountStudentsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return [new[] { 1, 1, 0, 0 }, new[] { 0, 1, 0, 1 }, 0];
        yield return [new[] { 1, 1, 1, 0, 0, 1 }, new[] { 1, 0, 0, 0, 1, 1 }, 3];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] students, int[] sandwiches, int expected)
    {
        var actual = Solution.CountStudents(students, sandwiches);
        Assert.Equal(expected, actual);
    }
}