// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class CanPartitionKSubsetsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new [] { 4, 3, 2, 3, 5, 2, 1 }, 4, true
        ];

        yield return
        [
            new [] { 1, 2, 3, 4 }, 3, false
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] nums, int k, bool expected)
    {
        var actual = Solution.CanPartitionKSubsets(nums, k);
        Assert.Equal(expected, actual);
    }
}