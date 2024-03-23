// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class ReverseKGroupUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.CreateListNode([1, 2, 3, 4, 5]),
            2,
            Util.CreateListNode([2, 1, 4, 3, 5])
        ];
        yield return
        [
            Util.CreateListNode([1, 2, 3, 4, 5]),
            3,
            Util.CreateListNode([3, 2, 1, 4, 5])
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(ListNode head, int k, ListNode expected)
    {
        var actual = Solution.ReverseKGroup(head, k);
        Assert.Equal(expected, actual, new ListNodeComparer());
    }
}