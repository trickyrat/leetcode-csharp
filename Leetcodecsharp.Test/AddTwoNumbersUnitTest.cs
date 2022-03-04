// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Leetcodecsharp.DataStructure;
using Xunit;

namespace Leetcodecsharp.Test
{
    public class AddTwoNumbersUnitTest
    {

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                Utils.GenerateLinkedList(new List<int> { 2, 4, 3 }),
                Utils.GenerateLinkedList(new List<int> { 5, 6, 4 }),
                new List<int> {  7, 0, 8  }
            };
            yield return new object[]
            {
                Utils.GenerateLinkedList(new List<int> { 0 }),
                Utils.GenerateLinkedList(new List<int> { 0 }),
                new List<int> {  0  }
            };
            yield return new object[]
            {
                Utils.GenerateLinkedList(new List<int> { 9, 9, 9, 9, 9, 9, 9 }),
                Utils.GenerateLinkedList(new List<int> { 9, 9, 9, 9 }),
                new List<int> { 8, 9, 9, 9, 0, 0, 0, 1 }
            };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(ListNode l1, ListNode l2, List<int> expected)
        {
            ListNode actualNode = Solution.AddTwoNumbers(l1, l2);
            List<int> actual = Utils.ConvertListNodeToList(actualNode);
            Assert.Equal(expected, actual);
        }
    }
}
