// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class RotateRightUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.GenerateListNode([1, 2, 3, 4, 5]),
            2,
            Util.GenerateListNode([4, 5, 1, 2, 3])
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(ListNode head, int k, ListNode expected)
    {
        var actual = Solution.RotateRight(head, k);
        Assert.Equal(expected, actual, new ListNodeComparer());
    }
}