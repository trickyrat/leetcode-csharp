// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Leetcodecsharp.DataStructure;

using System.Collections.Generic;

using Xunit;

namespace Leetcodecsharp.Test
{
    public class MiddleNodeUnitTest
    {
        [Fact]
        public void Test_Input_Even_Data_Should_OK()
        {
            ListNode input = Utils.GenerateLinkedList(new List<int> { 1, 2, 3, 4, 5, 6 });
            ListNode actualNode = Solution.MiddleNode(input);
            string actual = Utils.ConvertListNodeToString(actualNode);
            ListNode expectedNode = Utils.GenerateLinkedList(new List<int> { 4, 5, 6 });
            string expected = Utils.ConvertListNodeToString(expectedNode);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Test_Input_Odd_Data_Should_OK()
        {
            ListNode input = Utils.GenerateLinkedList(new List<int> { 1, 2, 3, 4, 5 });
            ListNode actualNode = Solution.MiddleNode(input);
            string actual = Utils.ConvertListNodeToString(actualNode);
            ListNode expectedNode = Utils.GenerateLinkedList(new List<int> { 3, 4, 5 });
            string expected = Utils.ConvertListNodeToString(expectedNode);
            Assert.Equal(expected, actual);
        }
    }
}
