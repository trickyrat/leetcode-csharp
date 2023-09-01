// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class RemoveElementUnitTest
{
    [Theory]
    [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2)]
    [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
    public void MultipleDataTest(int[] nums, int value, int expected)
    {
        var actual = Solution.RemoveElement(nums, value);
        Assert.Equal(expected, actual);
    }
}