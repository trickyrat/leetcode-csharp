// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class JumpUnitTest
{
    public static TheoryData<int[], int> Data => new()
    {
        { [2, 3, 1, 1, 4], 2 },
        { [2, 3, 0, 1, 4], 2 }
    };

    [Theory]
    [MemberData(nameof(Data))]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.Jump(nums);
        Assert.Equal(expected, actual);
    }
}