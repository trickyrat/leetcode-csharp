// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class AverageUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 4000, 3000, 1000, 2000 },
            2500.00000
        ];

        yield return
        [
            new[] { 1000, 2000, 3000 },
            2000.00000
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] salary, double expected)
    {
        var actual = Solution.Average(salary);
        Assert.Equal(expected, actual);
    }
}