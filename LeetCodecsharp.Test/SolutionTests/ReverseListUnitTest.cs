// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCodecsharp.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class ReverseListUnitTest
{
    public static IEnumerable<object[]> GetNodes()
    {
        yield return
        [
            Util.CreateListNode(new List<int> { 1, 2, 3, 4, 5 }),
            Util.CreateListNode(new List<int> { 5, 4, 3, 2, 1 })
        ];
        yield return
        [
            Util.CreateListNode(new List<int> { 1, 2 }),
            Util.CreateListNode(new List<int> { 2, 1 })
        ];
        yield return
        [
            null,
            null
        ];
    }


    [Theory]
    [MemberData(nameof(GetNodes))]
    public void Test(ListNode head, ListNode expectedNode)
    {
        var actualNode = Solution.ReverseList(head);
        var actual = actualNode?.ToString();
        var expected = expectedNode?.ToString();
        Assert.Equal(expected, actual);
    }
}
