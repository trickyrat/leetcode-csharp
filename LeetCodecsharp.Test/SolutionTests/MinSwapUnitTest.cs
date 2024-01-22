// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MinSwapUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 3, 5, 4 }, new[] { 1, 2, 3, 7 }, 1
        ];

        yield return
        [
            new[] { 0, 3, 5, 8, 9 }, new[] { 2, 1, 4, 6, 9 }, 1
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums1, int[] nums2, int expected)
    {
        var actual = Solution.MinSwap(nums1, nums2);
        Assert.Equal(expected, actual);
    }
}