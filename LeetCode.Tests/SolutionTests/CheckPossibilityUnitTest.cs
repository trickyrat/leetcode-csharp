// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class CheckPossibilityUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new [] { 4, 2, 3 }, true
        ];

        yield return
        [
            new [] { 4, 2, 1 }, false
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] nums, bool expected)
    {
        var actual = Solution.CheckPossibility(nums);
        Assert.Equal(expected, actual);
    }
}