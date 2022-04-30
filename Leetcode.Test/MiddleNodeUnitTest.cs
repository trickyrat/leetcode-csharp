// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Leetcode.DataStructure;
using Xunit;

namespace Leetcode.Test
{
    public class MiddleNodeUnitTest
    {

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] 
            {
                Utilities.CreateListNode(new List<int> { 1, 2, 3, 4, 5, 6 }),
                Utilities.CreateListNode(new List<int> { 4, 5, 6 })
            };
            yield return new object[]
            {
                Utilities.CreateListNode(new List<int> { 1, 2, 3, 4, 5,  }),
                Utilities.CreateListNode(new List<int> { 3, 4, 5 })
            };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void Test_Input_Even_Data_Should_OK(ListNode input, ListNode expected)
        {
            Solution solution = new Solution();
            ListNode actual = solution.MiddleNode(input);
            Assert.True(expected.Equals(actual));
        }
    }
}
