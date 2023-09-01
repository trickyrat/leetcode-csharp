// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

using System.Collections.Generic;

using Xunit;

namespace LeetCodecsharp.Test.SolutionTests;

public class RotateImageUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]
        {
            new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            },
            new int[][]
            {
                new int[] { 7, 4, 1 },
                new int[] { 8, 5, 2 },
                new int[] { 9, 6, 3 },
            }
        };
        yield return new object[]
        {
            new int[][]
            {
                new int[] { 5, 1, 9, 11 },
                new int[] { 2, 4, 8, 10 },
                new int[] { 13, 3, 6, 7 },
                new int[] { 15, 14, 12, 16 },
            },
            new int[][]
            {
                new int[] { 15, 13, 2, 5 },
                new int[] { 14, 3, 4, 1 },
                new int[] { 12, 6, 8, 9 },
                new int[] { 16, 7, 10, 11 },
            }
        };
    }


    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[][] nums, int[][] expected)
    {
        Solution.Rotate(nums);
        Assert.Equal(expected, nums);
    }
}