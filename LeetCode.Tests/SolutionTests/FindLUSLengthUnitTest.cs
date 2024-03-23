// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class FindLUSLengthUnitTest
{
    [Theory]
    [InlineData("aba", "cdc", 3)]
    [InlineData("aaa", "bbb", 3)]
    [InlineData("aaa", "aaa", -1)]
    public void MultipleDataTest(string a, string b, int expected)
    {
        var actual = Solution.FindLUSLength(a, b);
        Assert.Equal(expected, actual);
    }
}