// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class MinimumLengthUnitTest
{
    private readonly Solution _solution;

    public MinimumLengthUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("ca", 2)]
    [InlineData("cabaabac", 0)]
    [InlineData("aabccabba", 3)]
    public void MultipleDataTest(string s, int expected)
    {
        var actual = _solution.MinimumLength(s);
        Assert.Equal(expected, actual);
    }
}

