// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class SearchInsertUnitTest
{
    [Theory]
    [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
    [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
    [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
    public void MultipleDataTest(int[] nums, int target, int expected)
    {
        var actual = Solution.SearchInsert(nums, target);
        Assert.Equal(expected, actual);
    }

}