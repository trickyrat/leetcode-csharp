// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Linq;

using Xunit;

namespace Leetcode.Test
{
    public class GenerateParenthesisUnitTest
    {

        [Theory]
        [InlineData(3, new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
        [InlineData(1, new string[] { "()" })]
        public void MultipleDataTest(int n, string[] expected)
        {
            Solution solution = new Solution();
            string[] actual = solution.GenerateParenthesis(n).ToArray();
            Assert.Equal(expected, actual);
        }
    }
}