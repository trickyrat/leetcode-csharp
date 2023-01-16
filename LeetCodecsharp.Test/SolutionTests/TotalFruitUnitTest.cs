// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class TotalFruitUnitTest
{
    private readonly Solution _solution;

    public TotalFruitUnitTest()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 1 }, 3)]
    [InlineData(new int[] { 0, 1, 2, 2 }, 3)]
    [InlineData(new int[] { 1, 2, 3, 2, 2 }, 4)]
    public void MultipleDataTest(int[] fruits, int expected)
    {
        var actual = _solution.TotalFruit(fruits);
        Assert.Equal(expected, actual);
    }
}

