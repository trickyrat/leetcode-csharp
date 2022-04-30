// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class CountAndSayUnitTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(4, "1211")]
        public void Test(int n, string expected)
        {
            Solution solution = new Solution();
            string actual = solution.CountAndSay(n);
            Assert.Equal(expected, actual);
        }
    }
}
