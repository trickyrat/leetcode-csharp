// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leetcodecsharp.DataStructure;

using Xunit;

namespace Leetcodecsharp.Test
{
    public class ReverseListUnitTest
    {
        [Fact]
        public void Test()
        {
            ListNode head = Utils.InitLinkedList(new List<int> { 1,2,3,4,5 });
            ListNode actualNodes = Solution.ReverseList(head);
            ListNode expectedNode = Utils.InitLinkedList(new List<int> { 5, 4, 3, 2, 1 });
            string actual = Utils.PrintListNode(actualNodes);
            string expected = Utils.PrintListNode(expectedNode);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Input_Two_Nodes_Should_OK()
        {
            ListNode head = Utils.InitLinkedList(new List<int> { 1, 2 });
            ListNode actualNodes = Solution.ReverseList(head);
            ListNode expectedNode = Utils.InitLinkedList(new List<int> { 2, 1 });
            string actual = Utils.PrintListNode(actualNodes);
            string expected = Utils.PrintListNode(expectedNode);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Input_Null_Node_Should_OK()
        {
            ListNode head = null;
            ListNode actualNodes = Solution.ReverseList(head);
            ListNode expectedNode = null;
            string actual = Utils.PrintListNode(actualNodes);
            string expected = Utils.PrintListNode(expectedNode);
            Assert.Equal(expected, actual);
        }
    }
}
