// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests;
public class MinimumLengthUnitTest
{
    [Theory]
    [InlineData("ca", 2)]
    [InlineData("cabaabac", 0)]
    [InlineData("aabccabba", 3)]
    public void MultipleDataTest(string s, int expected)
    {
        var actual = Solution.MinimumLength(s);
        Assert.Equal(expected, actual);
    }
}

