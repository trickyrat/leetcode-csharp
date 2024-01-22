// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class DiStringMatchUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            "IDID", new[] { 0, 4, 1, 3, 2 }
        ];

        yield return
        [
            "III", new[] { 0, 1, 2, 3 }
        ];

        yield return
        [
            "DDI", new[] { 3, 2, 0, 1 }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(string s, int[] expected)
    {
        var actual = Solution.DIStringMatch(s);
        Assert.Equal(expected, actual);
    }
}