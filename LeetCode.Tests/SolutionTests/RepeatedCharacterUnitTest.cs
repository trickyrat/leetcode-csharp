// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class RepeatedCharacterUnitTest
{
    [Theory]
    [InlineData("abccbaacz", 'c')]
    [InlineData("abcdd", 'd')]
    [InlineData("aa", 'a')]
    [InlineData("zz", 'z')]
    public void Test(string s, char expected)
    {
        var actual = Solution.RepeatedCharacter(s);
        Assert.Equal(expected, actual);
    }
}