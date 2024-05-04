﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class FlipLightsUnitTest
{
    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(2, 1, 3)]
    [InlineData(3, 1, 4)]
    public void Test(int n, int presses, int expected)
    {
        var actual = Solution.FlipLights(n, presses);
        Assert.Equal(expected, actual);
    }

}