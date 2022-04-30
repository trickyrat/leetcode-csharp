// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class ConvertToBase7UnitTest
    {
        [Theory]
        [InlineData(100, "202")]
        [InlineData(-7, "-10")]
        public void MultipleDataTest(int input, string expected)
        {
            Solution solution = new Solution();
            string actual = solution.ConvertToBase7(input);
            Assert.Equal(expected, actual);
        }
    }
}