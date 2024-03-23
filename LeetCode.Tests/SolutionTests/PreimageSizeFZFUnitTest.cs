// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;
public class PreimageSizeFZFUnitTest
{
    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 0)]
    [InlineData(3, 5)]
    public void MultipleDataTest(int k, int expected)
    {
        var actual = Solution.PreimageSizeFzf(k);
        Assert.Equal(expected, actual);
    }
}

