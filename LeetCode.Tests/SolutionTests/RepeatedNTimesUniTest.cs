// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class RepeatedNTimesUniTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 2, 3, 3 }, 3
        ];
        yield return
        [
            new[] { 2, 1, 2, 5, 3, 2 }, 2
        ];
        yield return
        [
            new[] { 5, 1, 5, 2, 5, 3, 5, 4 }, 5
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.RepeatedNTimes(nums);
        Assert.Equal(expected, actual);
    }
}