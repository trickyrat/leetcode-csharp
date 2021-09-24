// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class LengthOfLongestSubstringUnitTest
    {
        [Fact]
        public void Test_Input_Palindromic_Alphas_Should_OK()
        {
            string input = "abcabcbb";
            int actual = Solution.LengthOfLongestSubstring(input);
            int expected = 3;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Input_Same_Alphas_Should_OK()
        {
            string input = "bbbbb";
            int actual = Solution.LengthOfLongestSubstring(input);
            int expected = 1;
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Test_Input_Different_Alphas_Should_OK()
        {
            string input = "pwwkew";
            int actual = Solution.LengthOfLongestSubstring(input);
            int expected = 3;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Input_Empty_String_Should_OK()
        {
            string input = "";
            int actual = Solution.LengthOfLongestSubstring(input);
            int expected = 0;
            Assert.Equal(expected, actual);
        }
    }
}
