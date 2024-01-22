// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using LeetCodecsharp.DataStructure;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class SwapPairsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.CreateListNode([1, 2, 3, 4]),
            Util.CreateListNode([2, 1, 4, 3])
        ];
        yield return
        [
            Util.CreateListNode(Array.Empty<int>()),
            Util.CreateListNode(Array.Empty<int>())
        ];
        yield return
        [
            Util.CreateListNode([1]),
            Util.CreateListNode([1])
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