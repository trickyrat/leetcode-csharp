// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCodecsharp.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MergeKListsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            new ListNode[]
            {
                Util.CreateListNode(new int[]{ 1,4,5}),
                Util.CreateListNode(new int[]{ 1,3,4}),
                Util.CreateListNode(new int[]{ 2, 6})
            },
            Util.CreateListNode(new int[]{ 1, 1, 2, 3, 4, 4, 5, 6 })
        };
        yield return new object[]
        {
            new ListNode[]{},
            null
        };
        yield return new object[]
        {
            new ListNode[]{null},
            null
        };
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(ListNode[] lists, ListNode expected)
    {
        var actual = Solution.MergeKLists(lists);
        Assert.Equal(expected, actual, new ListNodeComparer());
    }
}