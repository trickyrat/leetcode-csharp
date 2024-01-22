// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.InterviewSolutionTests;

public class MagicIndexUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 0, 1, 2, 3, 4 }, 0
        ];
        yield return
        [
            new[] { 0, 1, 3, 3, 4 }, 0
        ];
        yield return
        [
            new[] { 0, 2, 3, 3, 4 }, 0
        ];
        yield return
        [
            new[] { 1, 2, 2, 3, 4 }, 2
        ];
        yield return
        [
            new[] { 1, 2, 3, 4, 4 }, 4
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MagicIndexTest1(int[] nums, int expected)
    {
        var actual = InterviewSolution.FindMagicIndex(nums);
        Assert.Equal(expected, actual);
    }
}