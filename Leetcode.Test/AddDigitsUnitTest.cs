// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class AddDigitsUnitTest
    {
        private readonly Solution _solution;
        public AddDigitsUnitTest()
        {
            _solution = new Solution();
        }
        
        [Theory]
        [InlineData(38, 2)]
        [InlineData(0, 0)]
        [InlineData(int.MaxValue, 1)]
        public void MultipleDataTest(int input, int expected)
        {
            int actual = _solution.AddDigits(input);
            Assert.Equal(expected, actual);
        }
    }
}