// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCodecsharp.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

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
            Util.CreateListNode(new int[]{ 1, 2, 3, 4}),
            Util.CreateListNode(new int[]{ 2, 1, 4, 3})
        };
        yield return new object[]
        {
            Util.CreateListNode(new int[]{ }),
            Util.CreateListNode(new int[]{ })
        };
        yield return new object[]
        {
            Util.CreateListNode(new int[]{ 1 }),
            Util.CreateListNode(new int[]{ 1 })
        };
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(ListNode head, ListNode expected)
    {
        var actual = _solution.SwapPairs(head);
        Assert.Equal(expected, actual, new ListNodeComparer());
    }
}