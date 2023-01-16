// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class UniqueLetterStringUnitTest
{
    private readonly Solution _solution;

    public UniqueLetterStringUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("ABC", 10)]
    [InlineData("ABA", 8)]
    [InlineData("LEETCODE", 92)]
    public void MultipleDataTest(string s, int expected)
    {
        var actual = _solution.UniqueLetterString(s);
        Assert.Equal(expected, actual);
    }
}

