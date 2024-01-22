// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class FindCenterUnitTest
{
    public static IEnumerable<object[]> GetEdges()
    {
        yield return
        [
            (new[]
            {
                new[] { 1, 2 },
                new[] { 2, 3 },
                new[] { 4, 2 },
            }, 2)
        ];
        yield return
        [
            (new[]
            {
                new[] { 1, 2 },
                new[] { 5, 1 },
                new[] { 1, 3 },
                new[] { 1, 4 },
            }, 1)
        ];
    }


    [Theory]
    [MemberData(nameof(GetEdges))]
    public void Test((int[][] edges, int expected) input)
    {
        var actual = Solution.FindCenter(input.edges);
        Assert.Equal(input.expected, actual);
    }
}