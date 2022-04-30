// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test
{
    public class ReverseWordsUnitTest
    {
        [Theory]
        [InlineData("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
        [InlineData("God Ding", "doG gniD")]
        public void Test1(string s, string expected)
        {
            Solution solution = new Solution();
            string actual = solution.ReverseWords(s);
            Assert.Equal(expected, actual);
        }
    }
}
