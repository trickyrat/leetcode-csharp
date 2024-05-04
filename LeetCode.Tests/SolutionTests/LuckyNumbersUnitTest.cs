﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class LuckyNumbersUnitTest
{
    public static IEnumerable<object[]> GetMatrix()
    {
        yield return
        [
            new[]
            {
                new int[] { 3, 7, 8 },
                new int[] { 9, 11, 13 },
                new int[] { 15, 16, 17 },
            }, 
            new List<int> { 15 }
        ];
        yield return
        [
            new[]
            {
                new int[] { 1, 10, 4, 2 },
                new int[] { 9, 3, 8, 7 },
                new int[] { 15, 16, 17, 12 },
            }, 
            new List<int> { 12 }
        ];
        yield return
        [
            new[]
            {
                new int[] { 7, 8 },
                new int[] { 1, 2 },
            }, 
            new List<int> { 7 }
        ];
    }


    [Theory]
    [MemberData(nameof(GetMatrix))]
    public void Test1(int[][] matrix, List<int> expected)
    {

        var actual = Solution.LuckyNumbers(matrix).ToList();
        Assert.Equal(expected, actual);
    }
}
