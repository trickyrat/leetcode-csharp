// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class TrapUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6
        ];
        yield return
        [
            new[] { 4, 2, 0, 3, 2, 5 }, 9
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.Trap(nums);
        Assert.Equal(expected, actual);
    }
}