// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class MinOperations2UnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 1, 4, 2, 3 }, 5, 2
        ];

        yield return
        [
            new[] { 5, 6, 7, 8, 9 }, 4, -1
        ];

        yield return
        [
            new[] { 3, 2, 20, 1, 1, 3 }, 10, 5
        ];
    }
    
    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] nums, int x, int expected)
    {
        var actual = Solution.MinOperations(nums, x);
        Assert.Equal(expected, actual);
    }
}