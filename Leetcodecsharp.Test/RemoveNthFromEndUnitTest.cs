using Leetcodecsharp.DataStructure;

using System.Collections.Generic;

using Xunit;

namespace Leetcodecsharp.Test
{
    public class RemoveNthFromEndUnitTest
    {
        [Fact]
        public void Test_Input_Normal_Nodes_Should_OK()
        {
            ListNode head = Utils.InitLinkedList(new List<int> { 1, 2, 3, 4, 5 });
            ListNode actualNode = Solution.RemoveNthFromEnd(head, 2);
            string actual = Utils.PrintListNode(actualNode);
            ListNode expectedNode = Utils.InitLinkedList(new List<int> { 1, 2, 3, 5 });
            string expected = Utils.PrintListNode(expectedNode);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Input_Only_One_Node_And_Remove_It_Should_OK()
        {
            ListNode head = Utils.InitLinkedList(new List<int> { 1 });
            ListNode actualNode = Solution.RemoveNthFromEnd(head, 1);
            string actual = Utils.PrintListNode(actualNode);
            ListNode expectedNode = Utils.InitLinkedList(new List<int> { });
            string expected = Utils.PrintListNode(expectedNode);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Input_Two_Nodes_Should_OK()
        {
            ListNode head = Utils.InitLinkedList(new List<int> { 1, 2 });
            ListNode actualNode = Solution.RemoveNthFromEnd(head, 1);
            string actual = Utils.PrintListNode(actualNode);
            ListNode expectedNode = Utils.InitLinkedList(new List<int> { 1 });
            string expected = Utils.PrintListNode(expectedNode);
            Assert.Equal(expected, actual);
        }
    }
}
