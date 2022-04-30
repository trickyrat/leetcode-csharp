﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class MinimumDifferenceUnitTest
    {
        [Theory]
        [InlineData(new int[] { 90 }, 1, 0)]
        [InlineData(new int[] { 9, 4, 1, 7 }, 2, 2)]
        public void Test(int[] nums, int k, int expected)
        {
            Solution solution = new Solution();
            int actual = solution.MinimumDifference(nums, k);
            Assert.Equal(expected, actual);
        }

    }
}