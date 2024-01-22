// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class TrimMeanUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new int[] { 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 }, 2.00000d, 2.00001d
        ];
        yield return
        [
            new int[] { 6, 2, 7, 5, 1, 2, 0, 3, 10, 2, 5, 0, 5, 5, 0, 8, 7, 6, 8, 0 }, 4.00000d, 4.00001d
        ];
        yield return
        [
            new int[]
            {
                6, 0, 7, 0, 7, 5, 7, 8, 3, 4, 0, 7, 8, 1, 6, 8, 1, 1, 2, 4, 8, 1, 9, 5, 4, 3, 8, 5, 10, 8, 6, 6, 1, 0,
                6, 10, 8, 2, 3, 4
            },
            4.77777d,
            4.77778d
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] arr, double low, double high)
    {
        var actual = Solution.TrimMean(arr);
        Assert.InRange(actual, low, high);
    }
}