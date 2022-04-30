// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class PowerOfTwoUnitTest
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(16, true)]
        [InlineData(4, true)]
        [InlineData(3, false)]
        public void Test(int num, bool expected)
        {
            Solution solution = new Solution();
            bool actual = solution.IsPowerOfTwo(num);
            Assert.Equal(expected, actual);
        }
    }
}
