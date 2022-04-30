// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class OptimalDivisionUnitTest
    {
        [Fact]
        public void SingleTest()
        {
            Solution solution = new Solution();
            int[] nums = { 1000, 100, 10, 2 };
            string actual = solution.OptimalDivision(nums);
            string expected = "1000/(100/10/2)";
            Assert.Equal(actual, expected);
        }

    }
}