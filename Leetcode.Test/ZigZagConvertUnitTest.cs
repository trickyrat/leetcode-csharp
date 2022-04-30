// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class ZigZagConvertUnitTest
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("A", 1, "A")]
        public void Test(string s, int numRows, string expected)
        {
            Solution solution = new Solution();
            string actual = solution.Convert(s, numRows);
            Assert.Equal(expected, actual);
        }
    }
}