// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class RemoveDuplicatesUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 1, 2 }, 2
        ];
        yield return
        [
            new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.RemoveDuplicates(nums);
        Assert.Equal(expected, actual);
    }
}