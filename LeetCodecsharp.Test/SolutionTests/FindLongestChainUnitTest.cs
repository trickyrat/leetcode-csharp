// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class FindLongestChainUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[]
            {
                new[] { 1, 2 },
                new[] { 2, 3 },
                new[] { 3, 4 },
            },
            2
        ];
        yield return
        [
            new[]
            {
                new[] { 1, 2 },
                new[] { 7, 8 },
                new[] { 4, 5 },
            },
            3
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[][] pairs, int expected)
    {
        var actual = Solution.FindLongestChain(pairs);
        Assert.Equal(expected, actual);
    }

}

