// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class CheckPossibilityUnitTest
{
    private readonly Solution _solution;
    public CheckPossibilityUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 4, 2, 3 }, true)]
    [InlineData(new int[] { 4, 2, 1 }, false)]
    public void Test(int[] nums, bool expected)
    {
        var actual = _solution.CheckPossibility(nums);
        Assert.Equal(expected, actual);
    }
}