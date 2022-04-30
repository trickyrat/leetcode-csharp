// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class DivideUnitTest
    {
        [Theory]
        [InlineData(10, 3, 3)]
        [InlineData(7, -3, -2)]
        [InlineData(0, 1, 0)]
        [InlineData(1, 1, 1)]
        public void Test(int dividend, int divisor, int expected)
        {
            Solution solution = new Solution();
            int actual = solution.Divide(dividend, divisor);
            Assert.Equal(expected, actual);
        }
    }
}
