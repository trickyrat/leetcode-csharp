// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Leetcode.DataStructure;

using Xunit;

namespace Leetcode.Test
{
    public class IsPalindromeUnitTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 2, 1 }, true)]
        [InlineData(new int[] { 1, 2 }, false)]
        public void Test(int[] nums, bool expected)
        {
            Solution solution = new Solution();
            ListNode head = Utilities.CreateListNode(nums);
            bool actual = solution.IsPalindrome(head);
            Assert.Equal(expected, actual);
        }
    }
}
