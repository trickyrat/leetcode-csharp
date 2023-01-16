// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class RemoveDuplicatesUnitTest
{
    private readonly Solution _solution;

    public RemoveDuplicatesUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, 2)]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = _solution.RemoveDuplicates(nums);
        Assert.Equal(expected, actual);
    }
}