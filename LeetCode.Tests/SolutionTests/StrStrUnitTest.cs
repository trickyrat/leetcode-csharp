// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class StrStrUnitTest
{
    [Theory]
    [InlineData("hello", "ll", 2)]
    [InlineData("aaaaa", "bba", -1)]
    public void MultipleDataTest(string haystack, string needle, int expected)
    {
        var actual = Solution.StrStr(haystack, needle);
        Assert.Equal(expected, actual);
    }

}