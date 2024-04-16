// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class AddTwoNumbersUnitTest
{
    public static TheoryData<ListNode, ListNode, ListNode> Data =>
        new()
        {
            { Util.GenerateListNode([2, 4, 3]), Util.GenerateListNode([5, 6, 4]), Util.GenerateListNode([7, 0, 8]) },
            { Util.GenerateListNode([0]), Util.GenerateListNode([0]), Util.GenerateListNode([0]) },
            {
                Util.GenerateListNode([9, 9, 9, 9, 9, 9, 9]),
                Util.GenerateListNode([9, 9, 9, 9]),
                Util.GenerateListNode([8, 9, 9, 9, 0, 0, 0, 1])
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