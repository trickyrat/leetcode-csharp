// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCodecsharp.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class AddTwoNumbersUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            Util.CreateListNode(new List<int> { 2, 4, 3 }),
            Util.CreateListNode(new List<int> { 5, 6, 4 }),
            Util.CreateListNode(new List<int> {  7, 0, 8 })
        };
        yield return new object[]
        {
            Util.CreateListNode(new List<int> { 0 }),
            Util.CreateListNode(new List<int> { 0 }),
            Util.CreateListNode(new List<int> { 0 })
        };
        yield return new object[]
        {
            Util.CreateListNode(new List<int> { 9, 9, 9, 9, 9, 9, 9 }),
            Util.CreateListNode(new List<int> { 9, 9, 9, 9 }),
            Util.CreateListNode(new List<int> { 8, 9, 9, 9, 0, 0, 0, 1 })
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(ListNode l1, ListNode l2, ListNode expected)
    {
        var actual = Solution.AddTwoNumbers(l1, l2);
        Assert.Equal(expected, actual, new ListNodeComparer());
    }
}
