// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class FindMiddleIndexUnitTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, -1, 8, 4 }, 3)]
    [InlineData(new int[] { 1, -1, 4 }, 2)]
    [InlineData(new int[] { 2, 5 }, -1)]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.FindMiddleIndex(nums);
        Assert.Equal(expected, actual);
    }
}