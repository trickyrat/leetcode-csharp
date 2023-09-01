// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class CountKDifferenceUnitTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 1 }, 1, 4)]
    [InlineData(new int[] { 1, 3 }, 3, 0)]
    [InlineData(new int[] { 3, 2, 1, 5, 4 }, 2, 3)]
    public void MultipleDataTest(int[] nums, int k, int expected)
    {
        var actual = Solution.CountKDifference(nums, k);
        Assert.Equal(expected, actual);
    }
}