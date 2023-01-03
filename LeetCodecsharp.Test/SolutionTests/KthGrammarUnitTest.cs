// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;
public class KthGrammarUnitTest
{
    private readonly Solution _solution;

    public KthGrammarUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(1, 1, 0)]
    [InlineData(2, 1, 0)]
    [InlineData(2, 2, 1)]
    public void MultipleDataTest(int n, int k, int expcted)
    {
        var actual = _solution.KthGrammar(n, k);
        Assert.Equal(expcted, actual);
    }
}

