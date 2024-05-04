﻿// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.InterviewSolutionTests;

public class RotateMatrixUnitTest
{
    public static TheoryData<int[][], int[][]> Data
    {
        get
        {
            var data = new TheoryData<int[][], int[][]>
            {
                {
                    new int[][]
                    {
                        [1, 2, 3],
                        [4, 5, 6],
                        [7, 8, 9],
                    },
                    new int[][]
                    {
                        [7, 4, 1],
                        [8, 5, 2],
                        [9, 6, 3],
                    }
                },
                {
                    new int[][]
                    {
                        [5, 1, 9, 11],
                        [2, 4, 8, 10],
                        [13, 3, 6, 7],
                        [15, 14, 12, 16],
                    },
                    new int[][]
                    {
                        [15, 13, 2, 5],
                        [14, 3, 4, 1],
                        [12, 6, 8, 9],
                        [16, 7, 10, 11],
                    }
                }
            };
            return data;
        }
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void MultipleDataTest(int[][] nums, int[][] expected)
    {
        InterviewSolution.Rotate(nums);
        Assert.Equal(expected, nums);
    }
}