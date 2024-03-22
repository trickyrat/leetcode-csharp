// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class FindMedianSortedArraysUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 3 }, new[] { 2 }, 2.00000
        ];

        yield return
        [
            new[] { 1, 2 }, new[] { 3, 4 }, 2.50000
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] A, int[] B, double expected)
    {
        var actual = Solution.FindMedianSortedArrays(A, B);
        Assert.Equal(expected, actual);
    }
}