// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class NumComponentsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.CreateListNode([0, 1, 2, 3]),
            new[] { 0, 1, 3 },
            2
        ];
        yield return
        [
            Util.CreateListNode([0, 1, 2, 3, 4]),
            new[] { 0, 3, 1, 4 },
            2
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(ListNode head, int[] nums, int expected)
    {
        var actual = Solution.NumComponents(head, nums);
        Assert.Equal(expected, actual);
    }
}