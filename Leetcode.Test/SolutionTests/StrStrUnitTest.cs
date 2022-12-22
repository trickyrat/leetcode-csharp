// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class StrStrUnitTest
{
    private readonly Solution _solution;

    public StrStrUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData("hello", "ll", 2)]
    [InlineData("aaaaa", "bba", -1)]
    public void MultipleDataTest(string haystack, string needle, int expected)
    {
        var actual = _solution.StrStr(haystack, needle);
        Assert.Equal(expected, actual);
    }

}