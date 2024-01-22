// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class FirstMissingPositiveUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 2, 0 }, 3
        ];

        yield return
        [
            new[] { 3, 4, -1, 1 }, 2
        ];

        yield return
        [
            new[] { 7, 8, 9, 11, 12 }, 1
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.FirstMissingPositive(nums);
        Assert.Equal(expected, actual);
    }
}