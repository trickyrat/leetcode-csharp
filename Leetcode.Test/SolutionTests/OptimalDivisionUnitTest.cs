// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Test.SolutionTests;

public class OptimalDivisionUnitTest
{
    private readonly Solution _solution;

    public OptimalDivisionUnitTest()
    {
        _solution = new Solution();
    }

    [Fact]
    public void SingleTest()
    {
        int[] nums = { 1000, 100, 10, 2 };
        var actual = _solution.OptimalDivision(nums);
        var expected = "1000/(100/10/2)";
        Assert.Equal(actual, expected);
    }

}