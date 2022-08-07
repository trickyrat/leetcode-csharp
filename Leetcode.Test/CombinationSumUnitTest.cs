// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace Leetcode.Test;

public class CombinationSumUnitTest
{
    private readonly Solution _solution;
    public CombinationSumUnitTest()
    {
        _solution = new Solution();
    }


    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            new int[] { 2, 3, 6, 7 },
            7,
            new List<IList<int>>  
            {
                new List<int>{ 7 },
                new List<int>{ 2, 2, 3},
            }

        };
        yield return new object[]
        {
            new int[] { 2 },
            1,
            new List<IList<int>>()
        };
        yield return new object[]
        { 
            new int[] { 2, 3, 5 },
            8,
            new List<IList<int>>
            {
                new List<int>{ 3, 5 },
                new List<int>{ 2, 3, 3 },
                new List<int>{ 2, 2, 2, 2 },
            } 
        };
        yield return new object[]
        {  
            new int[] { 1 },
            1,
            new List<IList<int>>
            {
                new List<int>{ 1 },
            }
        };
        yield return new object[]
        {
            new int[] { 1 },
            2,
            new List<IList<int>>
            {
                new List<int>{ 1, 1 },
            }
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    private void MultipleDataTest(int[] candidates, int target, IList<IList<int>> expected)
    {
        var actual = _solution.CombinationSum(candidates, target);
        Assert.Equal(expected, actual);
    }
}
