// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Leetcodecsharp.DataStructure;
using Xunit;

namespace Leetcodecsharp.Test
{
    public class RemoveNthFromEndUnitTest
    {
        [Fact]
        public void Test_Input_Normal_Nodes_Should_OK()
        {
            ListNode head = Utils.GenerateLinkedList(new List<int> { 1, 2, 3, 4, 5 });
            ListNode actualNode = Solution.RemoveNthFromEnd(head, 2);
            string actual = Utils.ConvertListNodeToString(actualNode);
            ListNode expectedNode = Utils.GenerateLinkedList(new List<int> { 1, 2, 3, 5 });
            string expected = Utils.ConvertListNodeToString(expectedNode);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Input_Only_One_Node_And_Remove_It_Should_OK()
        {
            ListNode head = Utils.GenerateLinkedList(new List<int> { 1 });
            ListNode actualNode = Solution.RemoveNthFromEnd(head, 1);
            string actual = Utils.ConvertListNodeToString(actualNode);
            ListNode expectedNode = Utils.GenerateLinkedList(new List<int> { });
            string expected = Utils.ConvertListNodeToString(expectedNode);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Input_Two_Nodes_Should_OK()
        {
            ListNode head = Utils.GenerateLinkedList(new List<int> { 1, 2 });
            ListNode actualNode = Solution.RemoveNthFromEnd(head, 1);
            string actual = Utils.ConvertListNodeToString(actualNode);
            ListNode expectedNode = Utils.GenerateLinkedList(new List<int> { 1 });
            string expected = Utils.ConvertListNodeToString(expectedNode);
            Assert.Equal(expected, actual);
        }
    }
}
