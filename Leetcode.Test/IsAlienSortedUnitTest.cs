// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class IsAlienSortedUnitTest
    {
        private readonly Solution _solution;
        public IsAlienSortedUnitTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(new string[] { "hello", "leetcode" }, "hlabcdefgijkmnopqrstuvwxyz", true)]
        [InlineData(new string[] { "word", "world", "row" }, "worldabcefghijkmnpqstuvxyz", false)]
        [InlineData(new string[] { "apple", "app" }, "abcdefghijklmnopqrstuvwxyz", false)]
        public void Test(string[] words, string order, bool expected)
        {
            bool actual = _solution.IsAlienSorted(words, order);
            Assert.Equal(expected, actual);
        }
    }
}
