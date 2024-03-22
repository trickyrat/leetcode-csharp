// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class CombinationSumUnitTest
{
    public static TheoryData<int[], int, IList<IList<int>>> Data
    {
        get
        {
            var data = new TheoryData<int[], int, IList<IList<int>>>
            {
                {
                    [2, 3, 6, 7],
                    7,
                    new List<IList<int>>
                    {
                        new List<int> { 7 },
                        new List<int> { 2, 2, 3 },
                    }
                },
                {
                    [2],
                    1,
                    new List<IList<int>>()
                },
                {
                    [2, 3, 5],
                    8,
                    new List<IList<int>>
                    {
                        new List<int> { 3, 5 },
                        new List<int> { 2, 3, 3 },
                        new List<int> { 2, 2, 2, 2 },
                    }
                },
                {
                    [1],
                    1,
                    new List<IList<int>>
                    {
                        new List<int> { 1 },
                    }
                },
                {
                    [1],
                    2,
                    new List<IList<int>>
                    {
                        new List<int> { 1, 1 },
                    }
                }
            };
            return data;
        }
    }

    [Theory]
    [MemberData(nameof(Data))]
    private void MultipleDataTest(int[] candidates, int target, IList<IList<int>> expected)
    {
        var actual = Solution.CombinationSum(candidates, target);
        Assert.Equal(expected, actual);
    }
}