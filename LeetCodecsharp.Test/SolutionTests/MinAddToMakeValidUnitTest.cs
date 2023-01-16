// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class MinAddToMakeValidUnitTest
{
    private readonly Solution _solution;

    public MinAddToMakeValidUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData("())", 1)]
    [InlineData("(((", 3)]
    public void MultipleDataTest(string s, int expected)
    {
        var actual = _solution.MinAddToMakeValid(s);
        Assert.Equal(expected, actual);
    }
}

