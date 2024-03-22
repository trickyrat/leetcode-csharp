// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class MaxValueUnitTest
{
    [Theory]
    [InlineData(4, 2, 6, 2)]
    [InlineData(6, 1, 10, 3)]
    public void Test(int n, int index, int maxSum, int expected)
    {
        var actual = Solution.MaxValue(n, index, maxSum);
        Assert.Equal(expected, actual);
    }
}