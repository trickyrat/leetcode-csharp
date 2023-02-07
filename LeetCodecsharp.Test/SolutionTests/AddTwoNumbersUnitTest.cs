// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCodecsharp.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class AddTwoNumbersUnitTest
{
    private readonly Solution _solution;
    public AddTwoNumbersUnitTest()
    {
        _solution = new Solution();
    }
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            Utilities.CreateListNode(new List<int> { 2, 4, 3 }),
            Utilities.CreateListNode(new List<int> { 5, 6, 4 }),
            Utilities.CreateListNode(new List<int> {  7, 0, 8 })
        };
        yield return new object[]
        {
            Utilities.CreateListNode(new List<int> { 0 }),
            Utilities.CreateListNode(new List<int> { 0 }),
            Utilities.CreateListNode(new List<int> { 0 })
        };
        yield return new object[]
        {
            Utilities.CreateListNode(new List<int> { 9, 9, 9, 9, 9, 9, 9 }),
            Utilities.CreateListNode(new List<int> { 9, 9, 9, 9 }),
            Utilities.CreateListNode(new List<int> { 8, 9, 9, 9, 0, 0, 0, 1 })
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(ListNode l1, ListNode l2, ListNode expected)
    {
        var actual = _solution.AddTwoNumbers(l1, l2);
        Assert.Equal(expected, actual, new ListNodeComparer());
    }
}
