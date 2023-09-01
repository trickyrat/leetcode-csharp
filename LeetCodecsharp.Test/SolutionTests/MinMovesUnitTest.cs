// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class MinMovesUnitTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 3)]
    [InlineData(new int[] { 1, 1, 1 }, 0)]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.MinMoves(nums);
        Assert.Equal(expected, actual);
    }
}

