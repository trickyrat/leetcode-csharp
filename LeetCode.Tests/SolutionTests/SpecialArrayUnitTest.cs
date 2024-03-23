// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class SpecialArrayUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 3, 5 }, 2
        ];
        yield return
        [
            new[] { 0, 0 }, -1
        ];
        yield return
        [
            new[] { 0, 4, 3, 0, 4 }, 3
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.SpecialArray(nums);
        Assert.Equal(expected, actual);
    }
}