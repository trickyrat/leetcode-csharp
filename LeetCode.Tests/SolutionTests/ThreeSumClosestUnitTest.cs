// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class ThreeSumClosestUnitTest
{
    [Theory]
    [InlineData(new int[] { -1, 2, 1, -4 }, 1, 2)]
    [InlineData(new int[] { 0, 0, 0 }, 1, 0)]
    public void MultipleDataTest(int[] nums, int target, int expected)
    {

        var actual = Solution.ThreeSumClosest(nums, target);
        Assert.Equal(expected, actual);
    }


}