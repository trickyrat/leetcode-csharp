// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class LongestPalindromicSubstringUnitTest
    {
        [Theory]
        [InlineData("babad", new string[] { "bab", "aba" })]
        [InlineData("cbbd", new string[] { "bb" })]
        public void Test(string input, string[] expected)
        {
            string actual = Solution.LongestPalindrome(input);
            Assert.Contains(actual, expected);
        }
    }
}
