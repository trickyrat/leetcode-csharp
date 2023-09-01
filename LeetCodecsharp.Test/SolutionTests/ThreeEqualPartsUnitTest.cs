// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class ThreeEqualPartsUnitTest
{
    [Theory]
    [InlineData(new int[] { 1, 0, 1, 0, 1 }, new int[] { 0, 3 })]
    [InlineData(new int[] { 1, 1, 0, 1, 1 }, new int[] { -1, -1 })]
    [InlineData(new int[] { 1, 1, 0, 0, 1 }, new int[] { 0, 2 })]
    public void Test(int[] arr, int[] expected)
    {
        var actual = Solution.ThreeEqualParts(arr);
        Assert.Equal(expected, actual);
    }
}