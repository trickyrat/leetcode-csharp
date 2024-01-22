// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class LargestPerimeterUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 2, 1, 2 }, 5
        ];

        yield return
        [
            new[] { 1, 2, 1 }, 0
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.LargestPerimeter(nums);
        Assert.Equal(expected, actual);
    }
}