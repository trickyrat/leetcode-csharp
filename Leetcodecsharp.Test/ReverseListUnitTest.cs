// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Leetcodecsharp.DataStructure;

using Xunit;

namespace Leetcodecsharp.Test
{
    public class ReverseListUnitTest
    {
        public static IEnumerable<object[]> GetNodes()
        {
            yield return new object[]
            {
                Utils.GenerateLinkedList(new List<int> { 1, 2, 3, 4, 5 }),
                Utils.GenerateLinkedList(new List<int> { 5, 4, 3, 2, 1 })
            };
            yield return new object[]
            {
                Utils.GenerateLinkedList(new List<int> { 1, 2 }),
                Utils.GenerateLinkedList(new List<int> { 2, 1 })
            };
            yield return new object[]
            {
                null,
                null
            };
        }


        [Theory]
        [MemberData(nameof(GetNodes))]
        public void Test(ListNode head, ListNode expectedNode)
        {
            ListNode actualNode = Solution.ReverseList(head);
            string actual = Utils.ConvertListNodeToString(actualNode);
            string expected = Utils.ConvertListNodeToString(expectedNode);
            Assert.Equal(expected, actual);
        }
    }
}
