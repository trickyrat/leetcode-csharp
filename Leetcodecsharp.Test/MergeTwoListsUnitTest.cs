// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Leetcodecsharp.DataStructure;

using Xunit;

namespace Leetcodecsharp.Test
{
    public class MergeTwoListsUnitTest
    {
        [Fact]
        public void Test_Input_Contains_Same_Values_Should_Ok()
        {
            ListNode l1 = Utils.InitLinkedList(new List<int> { 1, 2, 4 });
            ListNode l2 = Utils.InitLinkedList(new List<int> { 1, 3, 4 });
            ListNode actualNode = Solution.MergeTwoLists(l1, l2);
            ListNode expectedNode = Utils.InitLinkedList(new List<int> { 1, 1, 2, 3, 4, 4 });
            string actual = Utils.PrintListNode(actualNode);
            string expected = Utils.PrintListNode(expectedNode);
            Assert.Equal(expected, actual);
        }



        [Theory]
        [InlineData(null, null)]
        public void Test_Input_Two_Empty_Nodes_Should_Ok(ListNode l1, ListNode l2)
        {
            ListNode actualNode = Solution.MergeTwoLists(l1, l2);
            ListNode expectedNode = null;
            string actual = Utils.PrintListNode(actualNode);
            string expected = Utils.PrintListNode(expectedNode);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Input_One_Empty_Node_Should_Ok()
        {
            ListNode l1 = null;
            ListNode l2 = Utils.InitLinkedList(new List<int> { 0 });
            ListNode actualNode = Solution.MergeTwoLists(l1, l2);
            ListNode expectedNode = Utils.InitLinkedList(new List<int> { 0 });
            string actual = Utils.PrintListNode(actualNode);
            string expected = Utils.PrintListNode(expectedNode);
            Assert.Equal(expected, actual);
        }
    }
}
