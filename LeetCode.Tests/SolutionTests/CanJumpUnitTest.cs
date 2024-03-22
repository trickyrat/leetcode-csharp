// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class CanJumpUnitTest
{
    public static TheoryData<int[], bool> Data => new()
    {
        { [2, 3, 1, 1, 4], true },
        { [3, 2, 1, 0, 4], false }
    };

    [Theory]
    [MemberData(nameof(Data))]
    public void MultipleDataTest(int[] nums, bool expected)
    {
        var actual = Solution.CanJump(nums);
        Assert.Equal(expected, actual);
    }
}