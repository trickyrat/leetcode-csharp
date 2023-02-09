// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.InterviewSolutionTests;

public class MagicIndexUnitTest
{
    private readonly InterviewSolution _solution;
    public MagicIndexUnitTest()
    {
        _solution = new InterviewSolution();
    }

    [Theory]
    [InlineData(new int[] { 0, 1, 2, 3, 4 }, 0)]
    [InlineData(new int[] { 0, 1, 3, 3, 4 }, 0)]
    [InlineData(new int[] { 0, 2, 3, 3, 4 }, 0)]
    [InlineData(new int[] { 1, 2, 2, 3, 4 }, 2)]
    [InlineData(new int[] { 1, 2, 3, 4, 4 }, 4)]
    public void MagicIndexTest1(int[] nums, int expected)
    {
        var actual = _solution.FindMagicIndex(nums);
        Assert.Equal(expected, actual);
    }
}