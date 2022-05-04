// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class FindTheWinnerUnitTest
    {
        private readonly Solution solution;

        public FindTheWinnerUnitTest()
        {
            solution = new Solution();
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(6, 5, 1)]
        public void MultipleDataTest(int n, int k, int expected)
        {
            int actual = solution.FindTheWinner(n, k);
            Assert.Equal(expected, actual);
        }

    }
}