// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MinOperationsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { "d1/", "d2/", "../", "d21/", "./" }, 2
        ];

        yield return
        [
            new[] { "d1/", "d2/", "./", "d3/", "../", "d31/" }, 3
        ];

        yield return
        [
            new[] { "d1/", "../", "../", "../" }, 0
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(string[] logs, int expected)
    {
        var actual = Solution.MinOperations(logs);
        Assert.Equal(expected, actual);
    }
}