// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class CountStudentsUnitTest
{
    public static TheoryData<int[], int[], int> Data => new()
    {
        { [1, 1, 0, 0], [0, 1, 0, 1], 0 },
        { [1, 1, 1, 0, 0, 1], [1, 0, 0, 0, 1, 1], 3 }
    };

    [Theory]
    [MemberData(nameof(Data))]
    public void MultipleDataTest(int[] students, int[] sandwiches, int expected)
    {
        var actual = Solution.CountStudents(students, sandwiches);
        Assert.Equal(expected, actual);
    }
}