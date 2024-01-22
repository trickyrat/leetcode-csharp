// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MajorityElementUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 3, 2, 3 }, 3
        ];
        yield return
        [
            new[] { 2, 2, 1, 1, 1, 2, 2 }, 2
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] nums, int expected)
    {
        var actual = Solution.MajorityElement(nums);
        Assert.Equal(expected, actual);
    }
}