﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class ConstructArrayUnitTest
{
    private readonly Solution _solution;

    public ConstructArrayUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(3, 1, new int[] { 1, 2, 3 })]
    [InlineData(3, 2, new int[] { 1, 3, 2 })]
    public void Test(int n, int k, int[] expected)
    {
        var actual = _solution.ConstructArray(n, k);
        Assert.Equal(expected, actual);
    }
}