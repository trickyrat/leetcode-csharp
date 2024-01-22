// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class ConstructArrayUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            3, 1, new[] { 1, 2, 3 }
        ];

        yield return
        [
            3, 2, new[] { 1, 3, 2 }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int n, int k, int[] expected)
    {
        var actual = Solution.ConstructArray(n, k);
        Assert.Equal(expected, actual);
    }
}