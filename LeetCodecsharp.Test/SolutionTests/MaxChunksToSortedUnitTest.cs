// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class MaxChunksToSortedUnitTest
{
    private readonly Solution _solution;

    public MaxChunksToSortedUnitTest()
    {
        _solution = new Solution();
    }


    [Theory]
    [InlineData(new int[] { 4, 3, 2, 1, 0 }, 1)]
    [InlineData(new int[] { 1, 0, 2, 3, 4 }, 4)]
    public void MultipleDataTest(int[] arr, int expected)
    {
        var actual = _solution.MaxChunksToSorted(arr);
        Assert.Equal(expected, actual);
    }
}

