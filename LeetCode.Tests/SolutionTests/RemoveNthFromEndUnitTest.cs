// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class RemoveNthFromEndUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.GenerateListNode([1, 2, 3, 4, 5]),
            2,
            Util.GenerateListNode([1, 2, 3, 5])
        ];
        yield return
        [
            Util.GenerateListNode([1]),
            1,
            Util.GenerateListNode([])
        ];
        yield return
        [
            Util.GenerateListNode([1, 2]),
            1,
            Util.GenerateListNode([1])
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test_Input_Normal_Nodes_Should_OK(ListNode input, int n, ListNode expected)
    {
        var actual = Solution.RemoveNthFromEnd(input, n);
        Assert.Equal(expected, actual, new ListNodeComparer());
    }
}