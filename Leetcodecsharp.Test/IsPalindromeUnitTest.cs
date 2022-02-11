// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Leetcodecsharp.DataStructure;

using Xunit;

namespace Leetcodecsharp.Test
{
    public class IsPalindromeUnitTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 2, 1 }, true)]
        [InlineData(new int[] { 1, 2 }, false)]
        public void Test(int[] nums, bool expected)
        {
            ListNode head = Utils.InitLinkedList(nums);
            bool actual = Solution.IsPalindrome(head);
            Assert.Equal(expected, actual);
        }
    }
}
