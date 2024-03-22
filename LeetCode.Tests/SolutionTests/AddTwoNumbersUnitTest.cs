// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using LeetCode.DataStructure;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class AddTwoNumbersUnitTest
{
    public static TheoryData<ListNode, ListNode, ListNode> Data =>
        new()
        {
            { Util.CreateListNode([2, 4, 3]), Util.CreateListNode([5, 6, 4]), Util.CreateListNode([7, 0, 8]) },
            { Util.CreateListNode([0]), Util.CreateListNode([0]), Util.CreateListNode([0]) },
            {
                Util.CreateListNode([9, 9, 9, 9, 9, 9, 9]),
                Util.CreateListNode([9, 9, 9, 9]),
                Util.CreateListNode([8, 9, 9, 9, 0, 0, 0, 1])
            }
        };

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(ListNode l1, ListNode l2, ListNode expected)
    {
        var actual = Solution.AddTwoNumbers(l1, l2);
        Assert.Equal(expected, actual, new ListNodeComparer());
    }
}