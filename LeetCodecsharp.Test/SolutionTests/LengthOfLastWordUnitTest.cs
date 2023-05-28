// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class LengthOfLastWordUnitTest
{
    private readonly Solution _solution;

    public LengthOfLastWordUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    public void MultipleDataTest(string s, int expected)
    {
        var actual = _solution.LengthOfLastWord(s);
        Assert.Equal(expected, actual);
    }
}

