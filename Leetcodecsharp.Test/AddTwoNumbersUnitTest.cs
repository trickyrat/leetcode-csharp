// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Leetcodecsharp.DataStructure;

using System.Collections.Generic;

using Xunit;

namespace Leetcodecsharp.Test
{
    public class AddTwoNumbersUnitTest
    {
        [Fact]
        public void Test_Input_Same_Length_Nodes_Should_OK()
        {
            ListNode l1 = Utils.GenerateLinkedList(new List<int> { 2, 4, 3 });
            ListNode l2 = Utils.GenerateLinkedList(new List<int> { 5, 6, 4 });
            ListNode actualNode = Solution.AddTwoNumbers(l1, l2);
            ListNode expectedNode = Utils.GenerateLinkedList(new List<int> { 7, 0, 8 });
            string actual = Utils.ConvertListNodeToString(actualNode);
            string expected = Utils.ConvertListNodeToString(expectedNode);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Test_Input_Two_Zero_Nodes_Should_OK()
        {
            ListNode l1 = Utils.GenerateLinkedList(new List<int> { 0 });
            ListNode l2 = Utils.GenerateLinkedList(new List<int> { 0 });
            ListNode actualNode = Solution.AddTwoNumbers(l1, l2);
            ListNode expectedNode = Utils.GenerateLinkedList(new List<int> { 0 });
            string actual = Utils.ConvertListNodeToString(actualNode);
            string expected = Utils.ConvertListNodeToString(expectedNode);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Input_Two_Nodes_With_Carry_Should_OK()
        {
            ListNode l1 = Utils.GenerateLinkedList(new List<int> { 9, 9, 9, 9, 9, 9, 9 });
            ListNode l2 = Utils.GenerateLinkedList(new List<int> { 9, 9, 9, 9 });
            ListNode actualNode = Solution.AddTwoNumbers(l1, l2);
            ListNode expectedNode = Utils.GenerateLinkedList(new List<int> { 8, 9, 9, 9, 0, 0, 0, 1 });
            string actual = Utils.ConvertListNodeToString(actualNode);
            string expected = Utils.ConvertListNodeToString(expectedNode);
            Assert.Equal(expected, actual);
        }
    }
}
