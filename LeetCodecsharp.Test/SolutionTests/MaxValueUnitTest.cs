﻿using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MaxValueUnitTest
{
    private readonly Solution _solution;

    public MaxValueUnitTest()
    {
        _solution = new Solution();
    }
    
    [Theory]
    [InlineData(4, 2, 6, 2)]
    [InlineData(6, 1, 10, 3)]
    public void Test(int n, int index, int maxSum, int expected)
    {
        var actual = _solution.MaxValue(n, index, maxSum);
        Assert.Equal(expected, actual);
    }
}