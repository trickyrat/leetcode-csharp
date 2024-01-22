// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class CombinationSumUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new[] { 2, 3, 6, 7 },
            7,
            new List<IList<int>>
            {
                new List<int>{ 7 },
                new List<int>{ 2, 2, 3},
            }

        ];
        yield return
        [
            new[] { 2 },
            1,
            new List<IList<int>>()
        ];
        yield return
        [
            new[] { 2, 3, 5 },
            8,
            new List<IList<int>>
            {
                new List<int>{ 3, 5 },
                new List<int>{ 2, 3, 3 },
                new List<int>{ 2, 2, 2, 2 },
            }
        ];
        yield return
        [
            new[] { 1 },
            1,
            new List<IList<int>>
            {
                new List<int>{ 1 },
            }
        ];
        yield return
        [
            new[] { 1 },
            2,
            new List<IList<int>>
            {
                new List<int>{ 1, 1 },
            }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    private void MultipleDataTest(int[] candidates, int target, IList<IList<int>> expected)
    {
        var actual = Solution.CombinationSum(candidates, target);
        Assert.Equal(expected, actual);
    }
}
