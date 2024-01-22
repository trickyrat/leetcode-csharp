// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class FrequencySortUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 1, 2, 2, 2, 3 }, new[] { 3, 1, 1, 2, 2, 2 }
        ];

        yield return
        [
            new[] { 2, 3, 1, 3, 2 }, new[] { 1, 3, 3, 2, 2 }
        ];

        yield return
        [
            new[] { -1, 1, -6, 4, 5, -6, 1, 4, 1 }, new[] { 5, -1, 4, 4, -6, -6, 1, 1, 1 }
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] nums, int[] expected)
    {
        var actual = Solution.FrequencySort(nums);
        Assert.Equal(expected, actual);
    }
}