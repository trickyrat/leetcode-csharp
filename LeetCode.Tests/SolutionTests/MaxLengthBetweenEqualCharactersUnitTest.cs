// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class MaxLengthBetweenEqualCharactersUnitTest
{
    [Theory]
    [InlineData("aa", 0)]
    [InlineData("abca", 2)]
    [InlineData("cbzyx", -1)]
    public void Test(string s, int expected)
    {
        var actual = Solution.MaxLengthBetweenEqualCharacters(s);
        Assert.Equal(expected, actual);
    }

}