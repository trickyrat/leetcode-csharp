// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class FindLongestChainUnitTest
{
    private readonly Solution _solution;

    public FindLongestChainUnitTest()
    {
        _solution = new Solution();
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
            },
            2
        };
        yield return new object[]
        {
            new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 7, 8 },
                new int[] { 4, 5 },
            },
            3
        };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[][] pairs, int expected)
    {
        var actual = _solution.FindLongestChain(pairs);
        Assert.Equal(expected, actual);
    }

}

