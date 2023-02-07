// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using LeetCodecsharp.DataStructure;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class RemoveNthFromEndUnitTest
{
    private readonly Solution _solution;
    public RemoveNthFromEndUnitTest()
    {
        _solution = new Solution();
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            Utilities.CreateListNode(new List<int> { 1, 2, 3, 4, 5 }),
            2,
            Utilities.CreateListNode(new List<int> { 1, 2, 3, 5 })
        };
        yield return new object[]
        {
            Utilities.CreateListNode(new List<int> { 1 }),
            1,
            Utilities.CreateListNode(new List<int> { })
        };
        yield return new object[]
        {
            Utilities.CreateListNode(new List<int> { 1, 2 }),
            1,
            Utilities.CreateListNode(new List<int> { 1 })
        };

    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test_Input_Normal_Nodes_Should_OK(ListNode input, int n, ListNode expected)
    {

        var actual = _solution.RemoveNthFromEnd(input, n);
        Assert.Equal(expected, actual, new ListNodeComparer());
    }
}
