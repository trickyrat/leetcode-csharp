// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests
{
    public class MaxSubArrayUnitTest
    {
        private readonly Solution _solution;

        public MaxSubArrayUnitTest()
        {
            _solution = new Solution();
        }


        [Theory]
        [InlineData(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 5, 4, -1, 7, 8 }, 23)]
        public void MultipleDataTest(int[] nums, int expected)
        {
            var actual = _solution.MaxSubArray(nums);
            Assert.Equal(expected, actual);
        }

    }
}