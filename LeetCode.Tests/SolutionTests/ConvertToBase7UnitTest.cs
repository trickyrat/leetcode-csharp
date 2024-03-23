// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests
{
    public class ConvertToBase7UnitTest
    {
        [Theory]
        [InlineData(100, "202")]
        [InlineData(-7, "-10")]
        public void MultipleDataTest(int input, string expected)
        {
            var actual = Solution.ConvertToBase7(input);
            Assert.Equal(expected, actual);
        }
    }
}