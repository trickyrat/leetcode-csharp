// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class ShuffleUnitTest
{
    private readonly Solution _solution;

    public ShuffleUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 2, 5, 1, 3, 4, 7 }, 3, new int[] { 2, 3, 5, 4, 1, 7 })]
    [InlineData(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4, new int[] { 1, 4, 2, 3, 3, 2, 4, 1 })]
    [InlineData(new int[] { 1, 1, 2, 2 }, 2, new int[] { 1, 2, 1, 2 })]
    public void Test(int[] nums, int n, int[] expected)
    {
        var actual = _solution.Shuffle(nums, n);
        Assert.Equal(expected, actual);
    }
}