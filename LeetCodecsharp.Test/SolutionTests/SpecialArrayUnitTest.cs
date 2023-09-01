// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class SpecialArrayUnitTest
{
    [Theory]
    [InlineData(new int[] { 3, 5 }, 2)]
    [InlineData(new int[] { 0, 0 }, -1)]
    [InlineData(new int[] { 0, 4, 3, 0, 4 }, 3)]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.SpecialArray(nums);
        Assert.Equal(expected, actual);
    }
}

