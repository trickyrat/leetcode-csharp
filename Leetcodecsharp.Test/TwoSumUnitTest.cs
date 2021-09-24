// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class TwoSumUnitTest
    {
        [Fact]
        public void TwoSumTest1()
        {
            int[] nums = { 0, 1, 1, 3, 5 };
            int target = 2;
            int[] actual = Solution.TwoSum(nums, target);
            int[] expected = { 1, 2 };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TwoSumTest2()
        {
            int[] nums = { -1, 1, 1, 3, 5 };
            int target = 2;
            int[] actual = Solution.TwoSum(nums, target);
            int[] expected = { 1, 2 };

            Assert.Equal(expected, actual);
        }
    }
}
