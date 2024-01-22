// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class RemoveDuplicatesFromSortedArrayIIUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 1, 1, 2, 2, 3 }, 5
        ];
        yield return
        [
            new[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }, 7
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] nums, int expected)
    {
        var actual = Solution.RemoveDuplicatesV2(nums);
        Assert.Equal(expected, actual);
    }
}