// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class MinMovesUnitTest
{
    private readonly Solution _solution;

    public MinMovesUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 3)]
    [InlineData(new int[] { 1, 1, 1 }, 0)]
    public void MultipleDataTest(int[] nums, int expected)
    {
        int actual = _solution.MinMoves(nums);
        Assert.Equal(expected, actual);
    }
}

