// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Linq;

using Xunit;

namespace Leetcode.Test;

public class GenerateParenthesisUnitTest
{
    private readonly Solution _solution;
    public GenerateParenthesisUnitTest()
    {
        _solution = new Solution();
    }
    [Theory]
    [InlineData(3, new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
    [InlineData(1, new string[] { "()" })]
    public void MultipleDataTest(int n, string[] expected)
    {
        
        string[] actual = _solution.GenerateParenthesis(n).ToArray();
        Assert.Equal(expected, actual);
    }
}