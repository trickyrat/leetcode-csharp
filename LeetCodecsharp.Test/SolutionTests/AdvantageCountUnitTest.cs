// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class AdvantageCountUnitTest
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, new int[] { 1, 10, 4, 11 }, new int[] { 2, 11, 7, 15 })]
    [InlineData(new int[] { 12, 24, 8, 32 }, new int[] { 13, 25, 32, 11 }, new int[] { 24, 32, 8, 12 })]
    public void Test(int[] nums1, int[] nums2, int[] expected)
    {
        var actual = Solution.AdvantageCount(nums1, nums2);
        Assert.Equal(expected, actual);
    }
}