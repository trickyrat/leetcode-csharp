// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class CanJumpUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 2, 3, 1, 1, 4 }, true
        ];
        yield return
        [
            new[] { 3, 2, 1, 0, 4 }, false
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, bool expected)
    {
        var actual = Solution.CanJump(nums);
        Assert.Equal(expected, actual);
    }
}