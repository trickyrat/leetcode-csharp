// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class ReverseWordsUnitTest
    {
        [Fact]
        public void Test1()
        {
            string input = "Let's take LeetCode contest";
            string actual = Solution.ReverseWords(input);
            string expected = "s'teL ekat edoCteeL tsetnoc";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            string input = "God Ding";
            string actual = Solution.ReverseWords(input);
            string expected = "doG gniD";
            Assert.Equal(expected, actual);
        }
    }
}
