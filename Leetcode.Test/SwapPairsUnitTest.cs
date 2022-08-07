// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Leetcode.DataStructure;

using Xunit;

namespace Leetcode.Test;

public class SwapPairsUnitTest
{
    private readonly Solution _solution;

    public SwapPairsUnitTest()
    {
        _solution = new Solution();
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            Utilities.CreateListNode(new int[]{ 1, 2, 3, 4}),
            Utilities.CreateListNode(new int[]{ 2, 1, 4, 3})
        };
        yield return new object[]
        {
            Utilities.CreateListNode(new int[]{ }),
            Utilities.CreateListNode(new int[]{ })
        };
        yield return new object[]
        {
            Utilities.CreateListNode(new int[]{ 1 }),
            Utilities.CreateListNode(new int[]{ 1 })
        };
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(ListNode head, ListNode expected)
    {
        ListNode actual = _solution.SwapPairs(head);
        Assert.Equal(expected, actual);
    }
}