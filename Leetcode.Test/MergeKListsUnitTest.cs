// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Leetcode.DataStructure;

using Xunit;

namespace Leetcode.Test
{
    public class MergeKListsUnitTest
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new ListNode[]
                {
                    Utilities.CreateListNode(new int[]{ 1,4,5}),
                    Utilities.CreateListNode(new int[]{ 1,3,4}),
                    Utilities.CreateListNode(new int[]{ 2, 6})
                },
                Utilities.CreateListNode(new int[]{ 1, 1, 2, 3, 4, 4, 5, 6 })
            };
            yield return new object[]
            {
                new ListNode[]{},
                null
            };
            yield return new object[]
            {
                new ListNode[]{null},
                null
            };
        }


        [Theory]
        [MemberData(nameof(GetData))]
        public void MultipleDataTest(ListNode[] lists, ListNode expected)
        {
            var actual = Solution.MergeKLists(lists);
            Assert.Equal(expected, actual);
        }
    }
}