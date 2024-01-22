// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class MinSubsequenceUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 4, 3, 10, 9, 8 }, new[] { 10, 9 }
        ];

        yield return
        [
            new[] { 4, 4, 7, 6, 7 }, new[] { 7, 7, 6 }
        ];

        yield return
        [
            new[] { 6 }, new[] { 6 }
        ];
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[] input, IList<int> expected)
    {
        var actual = Solution.MinSubsequence(input);
        Assert.Equal(expected, actual);
    }
}