// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Linq;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class GenerateParenthesisUnitTest
{
    [Theory]
    [InlineData(3, new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
    [InlineData(1, new string[] { "()" })]
    public void MultipleDataTest(int n, string[] expected)
    {

        var actual = Solution.GenerateParenthesis(n).ToArray();
        Assert.Equal(expected, actual);
    }
}