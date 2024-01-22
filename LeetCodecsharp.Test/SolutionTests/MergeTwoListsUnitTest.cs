// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCodecsharp.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MergeTwoListsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            Util.CreateListNode(new List<int> { 1, 2, 4 }),
            Util.CreateListNode(new List<int> { 1, 3, 4 }),
            new List<int> { 1, 1, 2, 3, 4, 4 }
        ];
        yield return
        [
            null,
              null,
              new List<int>()
        ];
        yield return
        [
            null,
               Util.CreateListNode(new List<int> { 0 }),
               new List<int>{ 0 }
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(ListNode l1, ListNode l2, List<int> expected)
    {

        var actualNode = Solution.MergeTwoLists(l1, l2);
        var actual = Util.ConvertListNodeToList(actualNode);
        Assert.Equal(expected, actual);
    }
}
