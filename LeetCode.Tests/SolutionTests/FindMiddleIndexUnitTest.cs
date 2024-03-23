// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class FindMiddleIndexUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 2, 3, -1, 8, 4 }, 3
        ];

        yield return
        [
            new[] { 1, -1, 4 }, 2
        ];

        yield return
        [
            new[] { 2, 5 }, -1
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.FindMiddleIndex(nums);
        Assert.Equal(expected, actual);
    }
}