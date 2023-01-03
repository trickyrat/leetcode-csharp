// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCode.Test.SolutionTests;
public class MinSubsequenceUnitTest
{
    private readonly Solution _solution;

    public MinSubsequenceUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 4, 3, 10, 9, 8 }, new int[] { 10, 9 })]
    [InlineData(new int[] { 4, 4, 7, 6, 7 }, new int[] { 7, 7, 6 })]
    [InlineData(new int[] { 6 }, new int[] { 6 })]
    public void MultipleDataTest(int[] input, IList<int> expected)
    {
        var actual = _solution.MinSubsequence(input);
        Assert.Equal(expected, actual);
    }
}

