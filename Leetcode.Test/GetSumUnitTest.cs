// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class GetSumUnitTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(7, 3, 10)]
        [InlineData(1, -2, -1)]
        public void Test_Should_OK(int a, int b, int expected)
        {
            int actual = Solution.GetSum(a, b);
            Assert.Equal(expected, actual);
        }
    }
}
