// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class CheckPossibilityUnitTest
{
    [Theory]
    [InlineData(new int[] { 4, 2, 3 }, true)]
    [InlineData(new int[] { 4, 2, 1 }, false)]
    public void Test(int[] nums, bool expected)
    {
        var actual = Solution.CheckPossibility(nums);
        Assert.Equal(expected, actual);
    }
}