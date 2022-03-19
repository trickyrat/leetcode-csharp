// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class ReverseIntegerUnitTest
    {

        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(0, 0)]
        public void MultipleDataTest(int input, int expected)
        {
            int actual = Solution.Reverse(input);
            Assert.Equal(expected, actual);
        }
    }
}