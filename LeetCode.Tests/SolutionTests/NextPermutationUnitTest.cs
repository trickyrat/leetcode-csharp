// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class NextPermutationUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 2, 3 }, new[] { 1, 3, 2 }
        ];

        yield return
        [
            new[] { 3, 2, 1 }, new[] { 1, 2, 3 }
        ];

        yield return
        [
            new[] { 1, 1, 5 }, new[] { 1, 5, 1 }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int[] expected)
    {
        Solution.NextPermutation(nums);
        Assert.Equal(expected, nums);
    }
}