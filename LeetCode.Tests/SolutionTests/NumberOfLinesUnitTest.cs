// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class NumberOfLinesUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[]
            {
                10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10
            },
            "abcdefghijklmnopqrstuvwxyz",
            new[] { 3, 60 }
        ];

        yield return
        [
            new[]
            {
                4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10
            },
            "bbbcccdddaaa",
            new[] { 2, 4 }
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] widths, string s, int[] expected)
    {
        var actual = Solution.NumberOfLines(widths, s);
        Assert.Equal(expected, actual);
    }
}