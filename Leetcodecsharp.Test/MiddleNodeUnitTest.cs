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
            ListNode input = Utils.InitLinkedList(new List<int> { 1, 2, 3, 4, 5, 6 });
            ListNode actualNode = Solution.MiddleNode(input);
            string actual = Utils.PrintListNode(actualNode);
            ListNode expectedNode = Utils.InitLinkedList(new List<int> { 4, 5, 6 });
            string expected = Utils.PrintListNode(expectedNode);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Test_Input_Odd_Data_Should_OK()
        {
            ListNode input = Utils.InitLinkedList(new List<int> { 1, 2, 3, 4, 5 });
            ListNode actualNode = Solution.MiddleNode(input);
            string actual = Utils.PrintListNode(actualNode);
            ListNode expectedNode = Utils.InitLinkedList(new List<int> { 3, 4, 5 });
            string expected = Utils.PrintListNode(expectedNode);
            Assert.Equal(expected, actual);
        }
    }
}
