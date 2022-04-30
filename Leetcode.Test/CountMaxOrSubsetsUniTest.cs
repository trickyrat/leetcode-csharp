// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class CountMaxOrSubsetsUniTest
    {

        [Theory]
        [InlineData(new int[] { 3, 1 }, 2)]
        [InlineData(new int[] { 2, 2, 2 }, 7)]
        [InlineData(new int[] { 3, 2, 1, 5 }, 6)]
        public void MultipleDataTest(int[] input, int expect)
        {
            Solution solution = new Solution();
            int actual = solution.CountMaxOrSubsets(input);
            Assert.Equal(expect, actual);
        }
    }
}