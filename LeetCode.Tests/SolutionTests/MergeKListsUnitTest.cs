﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class MergeKListsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[]
            {
                Util.CreateListNode([1, 4, 5]),
                Util.CreateListNode([1, 3, 4]),
                Util.CreateListNode([2, 6])
            },
            Util.CreateListNode([1, 1, 2, 3, 4, 4, 5, 6])
        ];
        yield return
        [
            Array.Empty<ListNode>(),
            null
        ];
        yield return
        [
            new ListNode[] { null },
            null
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(ListNode[] lists, ListNode expected)
    {
        var actual = Solution.MergeKLists(lists);
        Assert.Equal(expected, actual, new ListNodeComparer());
    }
}