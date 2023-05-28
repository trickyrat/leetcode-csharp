// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class RepeatedCharacterUnitTest
{
    private readonly Solution _solution;

    public RepeatedCharacterUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("abccbaacz", 'c')]
    [InlineData("abcdd", 'd')]
    [InlineData("aa", 'a')]
    [InlineData("zz", 'z')]
    public void Test(string s, char expected)
    {
        var actual = _solution.RepeatedCharacter(s);
        Assert.Equal(expected, actual);
    }
}