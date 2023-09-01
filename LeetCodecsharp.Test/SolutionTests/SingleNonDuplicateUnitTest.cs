// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class SingleNonDuplicateUnitTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 }, 2)]
    [InlineData(new int[] { 3, 3, 7, 7, 10, 11, 11 }, 10)]
    public void Test(int[] nums, int expected)
    {

        var actual = Solution.SingleNonDuplicate(nums);
        Assert.Equal(expected, actual);
    }
}
