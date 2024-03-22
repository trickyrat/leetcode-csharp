// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class ExclusiveTimeUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            2, new[] { "0:start:0", "1:start:2", "1:end:5", "0:end:6" }, new[] { 3, 4 }
        ];

        yield return
        [
            1, new[] { "0:start:0", "0:start:2", "0:end:5", "0:start:6", "0:end:6", "0:end:7" }, new[] { 8 }
        ];

        yield return
        [
            2, new[] { "0:start:0", "0:start:2", "0:end:5", "1:start:6", "1:end:6", "0:end:7" },
            new[] { 7, 1 }
        ];
        yield return
        [
            2, new[] { "0:start:0", "0:start:2", "0:end:5", "1:start:7", "1:end:7", "0:end:8" },
            new[] { 8, 1 }
        ];
        yield return
        [
            1, new[] { "0:start:0", "0:end:0" }, new[] { 1 }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int n, IList<string> logs, int[] expected)
    {
        var actual = Solution.ExclusiveTime(n, logs);
        Assert.Equal(expected, actual);
    }
}