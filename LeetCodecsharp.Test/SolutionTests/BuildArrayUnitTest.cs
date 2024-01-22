// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class BuildArrayUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 1, 3 }, 3,
            new[] { "Push", "Push", "Pop", "Push" }
        ];

        yield return
        [
            new[] { 1, 2, 3 }, 3, new[] { "Push", "Push", "Push" }
        ];

        yield return
        [
            new[] { 1, 2 }, 4, new[] { "Push", "Push" }
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] targets, int n, IList<string> expected)
    {
        var actual = Solution.BuildArray(targets, n);
        Assert.Equal(expected, actual);
    }
}