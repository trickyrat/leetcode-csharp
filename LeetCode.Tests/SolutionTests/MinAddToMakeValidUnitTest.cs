// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;
public class MinAddToMakeValidUnitTest
{
    [Theory]
    [InlineData("())", 1)]
    [InlineData("(((", 3)]
    public void MultipleDataTest(string s, int expected)
    {
        var actual = Solution.MinAddToMakeValid(s);
        Assert.Equal(expected, actual);
    }
}

