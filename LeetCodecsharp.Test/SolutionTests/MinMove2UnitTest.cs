// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MinMove2UnitTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 2)]
    [InlineData(new int[] { 1, 10, 2, 9 }, 16)]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.MinMove2(nums);
        Assert.Equal(expected, actual);
    }

}