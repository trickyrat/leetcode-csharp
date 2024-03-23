// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class SetZeroesUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            new int[][]
            {
                [1, 1, 1],
                [1, 0, 1],
                [1, 1, 1]
            },
            new int[][]
            {
                [1, 0, 1],
                [0, 0, 0],
                [1, 0, 1]
            }
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void MultipleDataTest(int[][] input, int[][] expected)
    {
        Solution.SetZeroes(input);
        Assert.Equal(input, expected);
    }
}