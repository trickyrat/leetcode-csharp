// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class CanPartitionKSubsetsUnitTest
{
    [Theory]
    [InlineData(new int[] { 4, 3, 2, 3, 5, 2, 1 }, 4, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 3, false)]
    public void Test(int[] nums, int k, bool expected)
    {
        var actual = Solution.CanPartitionKSubsets(nums, k);
        Assert.Equal(expected, actual);
    }
}