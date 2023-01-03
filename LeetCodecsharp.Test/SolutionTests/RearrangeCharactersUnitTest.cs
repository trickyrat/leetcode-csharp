// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests
{
    public class RearrangeCharactersUnitTest
    {
        private readonly Solution _solution;

        public RearrangeCharactersUnitTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData("ilovecodingonleetcode", "code", 2)]
        [InlineData("abcba", "abc", 1)]
        [InlineData("abbaccaddaeea", "aaaaa", 1)]
        public void MultipleDataTest(string s, string target, int expected)
        {
            var actual = _solution.RearrageCharacters(s, target);
            Assert.Equal(expected, actual);
        }
    }
}