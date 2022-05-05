// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class FindMiddleIndexUnitTest
    {
        private readonly Solution solution;

        public FindMiddleIndexUnitTest()
        {
            solution = new Solution();
        }


        [Theory]
        [InlineData(new int[] { 2, 3, -1, 8, 4 }, 3)]
        [InlineData(new int[] { 1, -1, 4 }, 2)]
        [InlineData(new int[] { 2, 5 }, -1)]
        public void MultipleDataTest(int[] nums, int expected)
        {
            int actual = solution.FindMiddleIndex(nums);
            Assert.Equal(expected, actual);
        }
    }
}