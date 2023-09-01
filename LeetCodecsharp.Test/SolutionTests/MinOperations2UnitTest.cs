// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MinOperations2UnitTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 4, 2, 3 }, 5, 2)]
    [InlineData(new int[] { 5, 6, 7, 8, 9 }, 4, -1)]
    [InlineData(new int[] { 3, 2, 20, 1, 1, 3 }, 10, 5)]
    public void Test(int[] nums, int x, int expected)
    {
        var actual = Solution.MinOperations(nums, x);
        Assert.Equal(expected, actual);
    }
}