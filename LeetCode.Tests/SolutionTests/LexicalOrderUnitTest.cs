// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class LexicalOrderUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            13, new[] { 1, 10, 11, 12, 13, 2, 3, 4, 5, 6, 7, 8, 9 }
        ];

        yield return
        [
            2, new[] { 1, 2 }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int n, IList<int> expected)
    {
        var actual = Solution.LexicalOrder(n);
        Assert.Equal(expected, actual);
    }
}