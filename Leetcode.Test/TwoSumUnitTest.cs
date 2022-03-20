// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class TwoSumUnitTest
    {
        [Theory]
        [InlineData(new int[] { 0, 1, 1, 3, 5 }, 2, new int[] { 1, 2 })]
        [InlineData(new int[] { -1, 1, 1, 3, 5 }, 2, new int[] { 1, 2 })]
        public void TwoSumTest1(int[] nums, int target, int[] expected)
        {
            int[] actual = Solution.TwoSum(nums, target);
            Assert.Equal(expected, actual);
        }


    }
}
