// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class JumpUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 2, 3, 1, 1, 4 }, 2
        ];

        yield return
        [
            new[] { 2, 3, 0, 1, 4 }, 2
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.Jump(nums);
        Assert.Equal(expected, actual);
    }
}