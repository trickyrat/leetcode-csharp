// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace Leetcode.Test.SolutionTests;
public class JumpUnitTest
{
    private readonly Solution _solution;

    public JumpUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(new int[] { 2, 3, 1, 1, 4 }, 2)]
    [InlineData(new int[] { 2, 3, 0, 1, 4 }, 2)]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = _solution.Jump(nums);
        Assert.Equal(expected, actual);
    }
}

