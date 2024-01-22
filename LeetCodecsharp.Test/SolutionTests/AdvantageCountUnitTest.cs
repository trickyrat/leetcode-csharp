// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class AdvantageCountUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 2, 7, 11, 15 },
            new[] { 1, 10, 4, 11 },
            new[] { 2, 11, 7, 15 }
        ];

        yield return
        [
            new[] { 12, 24, 8, 32 },
            new[] { 13, 25, 32, 11 },
            new[] { 24, 32, 8, 12 }
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] nums1, int[] nums2, int[] expected)
    {
        var actual = Solution.AdvantageCount(nums1, nums2);
        Assert.Equal(expected, actual);
    }
}