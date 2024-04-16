// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class SwapPairsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.GenerateListNode([1, 2, 3, 4]),
            Util.GenerateListNode([2, 1, 4, 3])
        ];
        yield return
        [
            Util.GenerateListNode(Array.Empty<int>()),
            Util.GenerateListNode(Array.Empty<int>())
        ];
        yield return
        [
            Util.GenerateListNode([1]),
            Util.GenerateListNode([1])
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(ListNode head, ListNode expected)
    {
        var actual = Solution.SwapPairs(head);
        Assert.Equal(expected, actual, new ListNodeComparer());
    }
}