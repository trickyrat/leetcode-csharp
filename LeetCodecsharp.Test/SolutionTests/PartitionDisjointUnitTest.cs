// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class PartitionDisjointUnitTest
{
    private readonly Solution _solution;

    public PartitionDisjointUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(new int[] { 5, 0, 3, 8, 6 }, 3)]
    [InlineData(new int[] { 1, 1, 1, 0, 6, 12 }, 4)]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = _solution.PartitionDisjoint(nums);
        Assert.Equal(expected, actual);
    }
}

