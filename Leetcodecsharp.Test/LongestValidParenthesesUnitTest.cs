﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcodecsharp.Test
{
    public class LongestValidParenthesesUnitTest
    {
        [Fact]
        public void Test1()
        {
            string s = "()()()(()";
            int actual = Solution.LongestValidParentheses(s);
            int expected = 6;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            string s = "(()";
            int actual = Solution.LongestValidParentheses(s);
            int expected = 2;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            string s = "()()()(())";
            int actual = Solution.LongestValidParentheses(s);
            int expected = 10;
            Assert.Equal(expected, actual);
        }
    }
}
