// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MajorityElementUnitTest
{
    private readonly Solution _solution;
    public MajorityElementUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 3, 2, 3 }, 3)]
    [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    public void MultipleDataTest(int[] nums, int expected)
    {

        var actual = _solution.MajorityElement(nums);
        Assert.Equal(expected, actual);
    }
}