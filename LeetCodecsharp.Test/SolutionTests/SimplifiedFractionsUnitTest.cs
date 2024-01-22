// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class SimplifiedFractionsUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            2, new[] { "1/2" }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int n, string[] expected)
    {
        var list = Solution.SimplifiedFractions(n);
        var actual = list.ToArray();
        Assert.Equal(expected, actual);
    }
}