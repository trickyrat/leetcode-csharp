// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class CalPointsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { "5", "2", "C", "D", "+" }, 30
        ];

        yield return
        [
            new[] { "5", "-2", "4", "C", "D", "9", "+", "+" }, 27
        ];

        yield return
        [
            new[] { "1" }, 1
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(string[] input, int expected)
    {
        var actual = Solution.CalPoints(input);
        Assert.Equal(expected, actual);
    }
}