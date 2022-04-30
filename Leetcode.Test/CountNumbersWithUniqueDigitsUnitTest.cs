// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class CountNumbersWithUniqueDigitsUnitTest
    {
        [Theory]
        [InlineData(2, 91)]
        [InlineData(0, 1)]
        public void MultipleDataTest(int n, int expected)
        {
            Solution solution = new Solution();
            int actual = solution.CountNumbersWithUniqueDigits(n);
            Assert.Equal(expected, actual);
        }
    }
}