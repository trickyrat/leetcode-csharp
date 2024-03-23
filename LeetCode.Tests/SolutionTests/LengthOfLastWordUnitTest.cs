// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;
public class LengthOfLastWordUnitTest
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    public void MultipleDataTest(string s, int expected)
    {
        var actual = Solution.LengthOfLastWord(s);
        Assert.Equal(expected, actual);
    }
}

