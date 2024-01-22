// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class KthGrammarUnitTest
{
    [Theory]
    [InlineData(1, 1, 0)]
    [InlineData(2, 1, 0)]
    [InlineData(2, 2, 1)]
    public void MultipleDataTest(int n, int k, int expected)
    {
        var actual = Solution.KthGrammar(n, k);
        Assert.Equal(expected, actual);
    }
}

