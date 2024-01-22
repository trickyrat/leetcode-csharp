// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class FinalPricesUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 8, 4, 6, 2, 3 }, new[] { 4, 2, 4, 2, 3 }
        ];

        yield return
        [
            new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 }
        ];

        yield return
        [
            new[] { 10, 1, 1, 6 }, new[] { 9, 0, 1, 6 }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int[] prices, int[] expected)
    {
        var actual = Solution.FinalPrices(prices);
        Assert.Equal(expected, actual);
    }
}