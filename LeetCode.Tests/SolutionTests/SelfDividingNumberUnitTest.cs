// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class SelfDividingNumberUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            1, 22, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 }
        ];
        yield return
        [
            47, 85, new[] { 48, 55, 66, 77 }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int left, int right, int[] expected)
    {
        var actual = Solution.SelfDividingNumbers(left, right);
        Assert.Equal(expected, actual.ToArray());
    }
}