// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;
public class TotalFruitUnitTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 1 }, 3)]
    [InlineData(new int[] { 0, 1, 2, 2 }, 3)]
    [InlineData(new int[] { 1, 2, 3, 2, 2 }, 4)]
    public void MultipleDataTest(int[] fruits, int expected)
    {
        var actual = Solution.TotalFruit(fruits);
        Assert.Equal(expected, actual);
    }
}

