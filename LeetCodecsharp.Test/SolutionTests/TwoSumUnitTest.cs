// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class TwoSumUnitTest
{
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new [] { 0, 1 })]
    public void TwoSumTest1(int[] nums, int target, int[] expected)
    {
        var actual = Solution.TwoSum(nums, target);
        Assert.Equal(expected, actual);
    }
}
