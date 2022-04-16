// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace Leetcode.Test
{
    public class GenerateParenthesisUnitTest
    {

        [Theory]
        [InlineData(3, new string[] { "((()))", "(()())", "(())()", "()(())", "()()()"})]
        [InlineData(1, new string[] { "()"})]
        public void MultipleDataTest(int n, string[] expected)
        {
            string[] actual = Solution.GenerateParenthesis(n).ToArray();
            Assert.Equal(expected, actual);
        }
    }
}