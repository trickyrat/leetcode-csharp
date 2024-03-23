// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class GenerateParenthesisUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            3, new[] { "((()))", "(()())", "(())()", "()(())", "()()()" }
        ];

        yield return
        [
            1, new[] { "()" }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int n, string[] expected)
    {
        var actual = Solution.GenerateParenthesis(n).ToArray();
        Assert.Equal(expected, actual);
    }
}