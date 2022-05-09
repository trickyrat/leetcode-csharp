// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class DIStringMatchUnitTest
    {
        private readonly Solution solution;

        public DIStringMatchUnitTest()
        {
            solution = new Solution();
        }

        [Theory]
        [InlineData("IDID", new int[] { 0, 4, 1, 3, 2 })]
        [InlineData("III", new int[] { 0, 1, 2, 3 })]
        [InlineData("DDI", new int[] { 3, 2, 0, 1 })]
        public void MultipleDataTest(string s, int[] expected)
        {
            int[] actual = solution.DIStringMatch(s);
            Assert.Equal(expected, actual);
        }
    }
}