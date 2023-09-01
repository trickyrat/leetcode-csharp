// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests
{
    public class RearrangeCharactersUnitTest
    {
        [Theory]
        [InlineData("ilovecodingonleetcode", "code", 2)]
        [InlineData("abcba", "abc", 1)]
        [InlineData("abbaccaddaeea", "aaaaa", 1)]
        public void MultipleDataTest(string s, string target, int expected)
        {
            var actual = Solution.RearrangeCharacters(s, target);
            Assert.Equal(expected, actual);
        }
    }
}