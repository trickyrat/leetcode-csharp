// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;
public class UniqueLetterStringUnitTest
{
    [Theory]
    [InlineData("ABC", 10)]
    [InlineData("ABA", 8)]
    [InlineData("LEETCODE", 92)]
    public void MultipleDataTest(string s, int expected)
    {
        var actual = Solution.UniqueLetterString(s);
        Assert.Equal(expected, actual);
    }
}

