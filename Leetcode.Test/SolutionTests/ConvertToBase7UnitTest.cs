// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests
{
    public class ConvertToBase7UnitTest
    {
        private readonly Solution _solution;

        public ConvertToBase7UnitTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(100, "202")]
        [InlineData(-7, "-10")]
        public void MultipleDataTest(int input, string expected)
        {
            var actual = _solution.ConvertToBase7(input);
            Assert.Equal(expected, actual);
        }
    }
}