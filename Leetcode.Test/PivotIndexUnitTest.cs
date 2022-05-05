// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class PivotIndexUnitTest
    {

        [Theory]
        [InlineData(new int[] { 1, 7, 3, 6, 5, 6 }, 3)]
        [InlineData(new int[] { 1, 2, 3 }, -1)]
        [InlineData(new int[] { 2, 1, -1 }, 0)]
        public void MultipleDataTest(int[] nums, int expect)
        {
            Solution solution = new Solution();
            int actual = solution.PivotIndex(nums);
            Assert.Equal(expect, actual);
        }
    }
}