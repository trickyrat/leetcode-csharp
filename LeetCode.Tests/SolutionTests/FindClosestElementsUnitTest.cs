// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class FindClosestElementsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 2, 3, 4, 5 }, 4, 3, new[] { 1, 2, 3, 4 }
        ];

        yield return
        [
            new[] { 1, 2, 3, 4, 5 }, 4, -1, new[] { 1, 2, 3, 4 }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] arr, int k, int x, IList<int> expected)
    {
        var actual = Solution.FindClosestElements(arr, k, x);
        Assert.Equal(expected, actual);
    }
}